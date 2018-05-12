using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace SHA3
{
    class SHA3
    {
        #region constants
        private static Byte matrixSize = 5 * 5;
        private static Byte state_length = 6; //(default: 6)(l)
        private static Byte state_width = 64; //(default: 64)(bit) ширина массива состояний (w = 2^l)
        private static Byte state_width_in_bytes = 8;
        private static UInt16 permutation_width = 1600; //(default: 1600)(bit) ширина перестановок (b = 25 * w)
        //при необходимости можно добавлять нестандартные режимы, при условии сохранения относительного расположения значений
        private static UInt16[] rate_array = { 1152, 1088, 832, 576 }; //(bit) (r = b - c)
        private static UInt16[] rate_in_bytes_array = { 144, 136, 104, 72 };
        private static UInt16[] capacity_array = { 448, 512, 768, 1024 }; //(bit) (c = security * 2)
        private static UInt16[] capacity_in_bytes_array = { 56, 64, 96, 128 };
        private static UInt16[] security_array = { 224, 256, 384, 512 };
        private static UInt16[] security_in_bytes_array = { 28, 32, 48, 64 };
        private static Byte rounds_number = 24; //(default: 24) 12 + 2 * l число раундов Keccak-f
        //((t + 1)(t + 2)/2) % (state_width = 64)
        private static Byte[,] offset = {
        {0, 36, 3, 41, 18},
        {1, 44, 10, 45, 2},
        {62, 6, 43, 15, 61},
        {28, 55, 25, 21, 56},
        {27, 20, 39, 8, 14}};
        //rotation _constants for l = 6 (rounds_number = 24)
        private static UInt64[] RC = {
        0x0000000000000001,
        0x0000000000008082,
        0x800000000000808A,
        0x8000000080008000,
        0x000000000000808B,
        0x0000000080000001,
        0x8000000080008081,
        0x8000000000008009,
        0x000000000000008A,
        0x0000000000000088,
        0x0000000080008009,
        0x000000008000000A,
        0x000000008000808B,
        0x800000000000008B,
        0x8000000000008089,
        0x8000000000008003,
        0x8000000000008002,
        0x8000000000000080,
        0x000000000000800A,
        0x800000008000000A,
        0x8000000080008081,
        0x8000000000008080,
        0x0000000080000001,
        0x8000000080008008};
        #endregion

        private static UInt64[,] B = new UInt64[5, 5];
        private static UInt64[] C = new UInt64[5];
        private static UInt64[] D = new UInt64[5];

        private static Byte[] Keccak(UInt16 security, Byte[] MessageB, Byte[] Key)
        {
            int constant_index = constant_index = Array.FindIndex(security_array, s => s == security);
            if (constant_index == -1) return new Byte[1] { 0x00 };
            UInt16 rate_in_bytes = rate_in_bytes_array[constant_index];
            UInt64[,] S = new UInt64[5, 5];
            for (Byte i = 0; i < 5; ++i)
                for (Byte j = 0; j < 5; ++j)
                    S[i, j] = 0;
            int k = 0;
            if (Key != null)
            {
                if (Key.Length != rate_in_bytes) return new Byte[1] { 0x00 };
                State_Change(S, Key, rate_in_bytes);
            }
            while (k <= MessageB.Length - rate_in_bytes)
            {
                State_Change(S, SubArray(MessageB, k, rate_in_bytes), rate_in_bytes);
                k += rate_in_bytes;
            }
            Last_block_proc(S, SubArray(MessageB, k, MessageB.Length - k), rate_in_bytes);            
            return Squeezing(S, rate_in_bytes).Take(security / 8).ToArray();
        }

        private static Byte[] Keccak(UInt16 security, FileStream MessageFS, Byte[] Key)
        {
            int constant_index = constant_index = Array.FindIndex(security_array, s => s == security);
            if (constant_index == -1) return new Byte[1] { 0x00 };
            UInt16 rate_in_bytes = rate_in_bytes_array[constant_index];
            UInt64[,] S = new UInt64[5, 5];
            for (Byte i = 0; i < 5; ++i)
                for (Byte j = 0; j < 5; ++j)
                    S[i, j] = 0;
            Byte[] I64 = new Byte[rate_in_bytes];
            int len;
            if (Key != null)
            {
                if (Key.Length != rate_in_bytes) return new Byte[1] { 0x00 };
                State_Change(S, Key, rate_in_bytes);
            }
            while ((len = MessageFS.Read(I64, 0, rate_in_bytes)) == rate_in_bytes)
            {
                State_Change(S, I64, rate_in_bytes);
            }
            Last_block_proc(S, SubArray(I64, 0, len), rate_in_bytes);            
            return Squeezing(S, rate_in_bytes).Take(security / 8).ToArray();
        }

        private static UInt64[,] Last_block_proc(UInt64[,] State, Byte[] MessageB, UInt16 Rate_in_bytes)
        {
            UInt16 delta = (UInt16)(Rate_in_bytes - MessageB.Length);
            Byte[] Pad_Message = new Byte[Rate_in_bytes];
            int pos = 0;
            for (int i = 0; i < MessageB.Length; ++i)
            {
                Pad_Message[pos] = MessageB[i];
                ++pos;
            }
            if (delta == 1)
            {
                Pad_Message[pos] = 0x86;//0x61;//0110 0001
            }
            else
            {
                Pad_Message[pos] = 0x06;//0x60;//0110 0000
                delta -= 2;
                while (delta > 0)
                {
                    Pad_Message[pos + delta] = 0x00;
                    --delta;
                }
                Pad_Message[Pad_Message.Length - 1] = 0x80;//0x01;
            }
            State_Change(State, Pad_Message, Rate_in_bytes);
            return State;
        }

        private static UInt64[,] State_Change(UInt64[,] State, Byte[] Message, UInt16 Rate_in_bytes)
        {
            int pos;
            for (Byte ib = 0; ib < 5; ++ib)
                for (Byte jb = 0; jb < 5; ++jb)
                {
                    pos = ib + jb * 5;
                    // По умолчанию < 9, тк длина каждой подстроки 72 байта или 9 слов по 4 байта 
                    if (pos < (Rate_in_bytes / state_width_in_bytes))
                    {
                        pos *= state_width_in_bytes;
                        for (Byte i = 0; i < state_width_in_bytes; ++i)
                        {
                            State[ib, jb] ^= ((UInt64)(Message[pos + i]) << (i * 8));
                        }
                    }
                    else break;
                }
            //Keccak_f
            for (Byte i = 0; i < rounds_number; i++)
                State = Round(State, RC[i]);
            return State;
        }

        private static Byte[] SubArray(Byte[] Array, int position, int length)
        {
            Byte[] subArray = new Byte[length];
            for (int i = 0; i < length; ++i)
            {
                subArray[i] = Array[i + position];
            }
            return subArray;
        }

        private static Byte[] Squeezing(UInt64[,] State, UInt16 Rate_in_bytes)
        {
            Byte[] hash = new Byte[Rate_in_bytes];
            byte[] temp = new Byte[8];
            int pos, cur = 0;
            for (Byte jb = 0; jb < 5; ++jb)
                for (Byte ib = 0; ib < 5; ++ib)
                {
                    pos = ib + jb * 5;
                    if (pos < (Rate_in_bytes / state_width_in_bytes))
                    {
                        temp = BitConverter.GetBytes(State[ib, jb]);
                        for (int j = 0; j < 8; ++j)
                        {
                            hash[cur + j] = temp[j];
                        }
                        cur += 8;
                    }
                }
            return hash;
        }

        private static UInt64[,] Round(UInt64[,] A, UInt64 RC_i)
        {
            Byte i, j;

            //Тета
            for (i = 0; i < 5; i++)
                C[i] = A[i, 0] ^ A[i, 1] ^ A[i, 2] ^ A[i, 3] ^ A[i, 4];
            for (i = 0; i < 5; i++)
                D[i] = C[(i + 4) % 5] ^ Rotate(C[(i + 1) % 5], 1, state_width);
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    A[i, j] = A[i, j] ^ D[i];

            //Ро и пи
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    B[j, (2 * i + 3 * j) % 5] = Rotate(A[i, j], offset[i, j], state_width);

            //Хи
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    A[i, j] = B[i, j] ^ ((~B[(i + 1) % 5, j]) & B[(i + 2) % 5, j]);

            //Йота
            A[0, 0] = A[0, 0] ^ RC_i;

            return A;
        }

        private static UInt64 Rotate(UInt64 x, Byte n, Byte w)
        {
            return ((x << (n % w)) | (x >> (w - (n % w))));
        }

        private static Byte[][] Key_transform(string Key, UInt16 Rate_in_bytes)
        {
            int i;
            for (i= Key.Length; i < Rate_in_bytes; ++i)
            {
                Key += "\0";
            }
            Byte[] KeyB = StringToByte(Key);
            Byte[] KeyIp = new Byte[Rate_in_bytes];
            Byte[] KeyOp = new Byte[Rate_in_bytes];
            if (KeyB.Length > Rate_in_bytes)
            {
                Byte[] temp = Keccak(512, KeyB, null);
                KeyB = new Byte[Rate_in_bytes];
                for (i = 0; i < temp.Length; ++i)
                {
                    KeyB[i] = temp[i];
                }
                for (; i < Rate_in_bytes; ++i)
                {
                    KeyB[i] = 0x00;
                }
            }
            for (i = 0; i < Rate_in_bytes; ++i)
            {
                KeyIp[i] = (byte)(0x36 ^ KeyB[i]);
                KeyOp[i] = (byte)(0x5C ^ KeyB[i]);
            }
            return new Byte[2][] { KeyIp, KeyOp };
        }

        private static Byte[] StringToByte(string str)
        {
            str = str.Replace("\r", "");
            Byte[] r = Encoding.UTF8.GetBytes(str);
            return r;
        }

        private static String ByteToHex(Byte[] b)
        {
            string s = "";
            for (Int32 i = 0; i < b.Length; ++i)
                s += String.Format("{0:x2}", b[i]);
            return s;
        }

        private static Byte[] HexToByte(string str)
        {
            try
            {
                str = str.Trim();
                byte[] bytes = new byte[str.Length / 2];
                for (int i = 0; i < bytes.Length; ++i)
                {
                    bytes[i] = byte.Parse(str.Substring(i * 2, 2), NumberStyles.HexNumber);
                }
                return bytes;
            }
            catch (Exception)
            {
                return new Byte[0];
            }
        }

        #region initiating methods
        public static string SHA3_512(string Message)
        {
            return ByteToHex(Keccak(512, StringToByte(Message), null));
        }
        public static string SHA3_512_HEX(string Message)
        {
            return ByteToHex(Keccak(512, HexToByte(Message), null));
        }

        public static string SHA3_512(FileStream MessageFS)
        {
            return ByteToHex(Keccak(512, MessageFS, null));
        }

        public static string SHA3_384(string Message)
        {
            return ByteToHex(Keccak(384, StringToByte(Message), null));
        }
        public static string SHA3_384_HEX(string Message)
        {
            return ByteToHex(Keccak(384, HexToByte(Message), null));
        }

        public static string SHA3_384(FileStream MessageFS)
        {
            return ByteToHex(Keccak(384, MessageFS, null));
        }

        public static string SHA3_256(string Message)
        {
            return ByteToHex(Keccak(256, StringToByte(Message), null));
        }
        public static string SHA3_256_HEX(string Message)
        {
            return ByteToHex(Keccak(256, HexToByte(Message), null));
        }

        public static string SHA3_256(FileStream MessageFS)
        {
            return ByteToHex(Keccak(256, MessageFS, null));
        }

        public static string SHA3_224(string Message)
        {
            return ByteToHex(Keccak(224, StringToByte(Message), null));
        }
        public static string SHA3_224_HEX(string Message)
        {
            return ByteToHex(Keccak(224, HexToByte(Message), null));
        }

        public static string SHA3_224(FileStream MessageFS)
        {
            return ByteToHex(Keccak(224, MessageFS, null));
        }

        public static string SHA3_HMAC_512(string Message, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 72);
            return ByteToHex(Keccak(512, Keccak(512, StringToByte(Message), KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_512_HEX(string Message, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 72);
            return ByteToHex(Keccak(512, Keccak(512, HexToByte(Message), KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_512(FileStream MessageFS, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 72);
            return ByteToHex(Keccak(512, Keccak(512, MessageFS, KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_384(string Message, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 104);
            return ByteToHex(Keccak(384, Keccak(384, StringToByte(Message), KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_384_HEX(string Message, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 104);
            return ByteToHex(Keccak(384, Keccak(384, HexToByte(Message), KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_384(FileStream MessageFS, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 104);
            return ByteToHex(Keccak(384, Keccak(384, MessageFS, KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_256(string Message, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 136);
            return ByteToHex(Keccak(256, Keccak(256, StringToByte(Message), KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_256_HEX(string Message, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 136);
            return ByteToHex(Keccak(256, Keccak(256, HexToByte(Message), KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_256(FileStream MessageFS, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 136);
            return ByteToHex(Keccak(256, Keccak(256, MessageFS, KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_224(string Message, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 144);
            return ByteToHex(Keccak(224, Keccak(224, StringToByte(Message), KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_224_HEX(string Message, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 144);
            return ByteToHex(Keccak(224, Keccak(224, HexToByte(Message), KeyIpOp[0]), KeyIpOp[1]));
        }

        public static string SHA3_HMAC_224(FileStream MessageFS, string Key)
        {
            Byte[][] KeyIpOp = Key_transform(Key, 144);
            return ByteToHex(Keccak(224, Keccak(224, MessageFS, KeyIpOp[0]), KeyIpOp[1]));
        }
        #endregion
    }
}