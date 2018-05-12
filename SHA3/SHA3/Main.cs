using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SHA3
{
    [Serializable]
    public struct KeyRestrict
    {
        UInt16 min_length;
        UInt16 max_length;
        bool numbers;
        bool lowercase;
        bool capitals;
        bool special_chars;
        public UInt16 Min_length { get => min_length; set => min_length = value; }
        public UInt16 Max_length { get => max_length; set => max_length = value; }
        public bool Numbers { get => numbers; set => numbers = value; }
        public bool Lowercase { get => lowercase; set => lowercase = value; }
        public bool Capitals { get => capitals; set => capitals = value; }
        public bool Special_chars { get => special_chars; set => special_chars = value; }
        public KeyRestrict(UInt16 minimal_length, UInt16 maximal_length, bool contain_numbers, bool contain_lowercase, bool contain_capitals, bool contain_special_chars)
        {
            min_length = minimal_length;
            max_length = maximal_length;
            numbers = contain_numbers;
            lowercase = contain_lowercase;
            capitals = contain_capitals;
            special_chars = contain_special_chars;
        }
    }
    public partial class Main : Form
    {
        public static string key;
        public static KeyRestrict keyRestrict = new KeyRestrict(0, 0, false, false, false, false);
        private string savePath;
        private string choosePath;
        private const string settingsPath = ".\\settings";
        private static string hashFunction;
        private double reference_test_time = 70025;
        private double performance_test_time;

        public Main()
        {
            InitializeComponent();
            FileMod(false);
            toolStripComboBox_Hash_Func_Choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            toolStripComboBox_Hash_Func_Choose.SelectedItem = toolStripComboBox_Hash_Func_Choose.Items[0];
            long start = DateTime.Now.Ticks;
            SHA3.SHA3_512("");
            long end = DateTime.Now.Ticks;
            performance_test_time = end - start;
            if (File.Exists(settingsPath))
                try
                {
                    using (FileStream fs = new FileStream(settingsPath, FileMode.OpenOrCreate, FileAccess.Read))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        keyRestrict = (KeyRestrict)formatter.Deserialize(fs);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Файл настроек повреждён\nнастройки будут сброшены.", "Ошибка");
                }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenHashFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                Hash_textBox.Text = File.ReadAllText(OPF.FileName);
            }
        }

        private void SaveAsHashFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog();
            if (SF.ShowDialog() == DialogResult.OK)
            {
                savePath = SF.FileName;
                File.WriteAllText(savePath, Hash_textBox.Text);
            }
        }

        private void сохранитьТекстВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog();
            if (SF.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(SF.FileName, Text_textBox.Text);
            }
        }

        private void открытьТекстИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(OPF.FileName);
                double len_in_MiBs = fileInfo.Length / 1024 / 1024;
                if (len_in_MiBs > 100)
                    MessageBox.Show("Файл имеет большой размер!", "Предупреждение");
                else
                    Text_textBox.Text = File.ReadAllText(OPF.FileName);
            }
        }

        private void TextModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileModeToolStripMenuItem.Checked)
            {
                FileMod(false);
            }
        }

        private void FileModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextModeToolStripMenuItem.Checked)
            {
                FileMod(true);
            }
        }

        private void KeyConstraintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeySet keySet = new KeySet();
            keySet.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void Choose_File_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                choosePath = OPF.FileName;
                textBox_Choose_File_Path.Text = choosePath;
                FileInfo fileInfo = new FileInfo(choosePath);
                double len_in_MiBs = fileInfo.Length/1024/1024;
                if (len_in_MiBs > 10)
                    MessageBox.Show("Файл имеет большой размер и может хешироваться долго.\n(Ожидаемое время: не менее " + (Math.Truncate(len_in_MiBs * 0.41)).ToString() + "с)", "Предупреждение");
            }
        }

        private void toolStripComboBox_Hash_Func_Choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            hashFunction = toolStripComboBox_Hash_Func_Choose.SelectedItem.ToString();
        }

        private void button_key_input_Click(object sender, EventArgs e)
        {
            KeyInput keyInput = new KeyInput();
            keyInput.ShowDialog();
        }

        private void Calc_Text_Hash_button_Click(object sender, EventArgs e)
        {
            Hash_textBox.Text = Get_SHA3_Hash(Text_textBox.Text, checkBox_HEX.Checked);
            result_label_reset();
        }

        private void Calc_Text_Hash_with_key_button_Click(object sender, EventArgs e)
        {
            if (key_not_empty_Check())
            {
                Hash_textBox.Text = Get_HMAC_SHA3_Hash(Text_textBox.Text, key, checkBox_HEX.Checked);
                result_label_reset();
            }
        }

        private void Check_Text_Hash_button_Click(object sender, EventArgs e)
        {
            Hash_compare(Get_SHA3_Hash(Text_textBox.Text, checkBox_HEX.Checked));
        }

        private void button_Check_Text_Hash_with_key_Click(object sender, EventArgs e)
        {
            if (key_not_empty_Check())
            {
                Hash_compare(Get_HMAC_SHA3_Hash(Text_textBox.Text, key, checkBox_HEX.Checked));
            }
        }

        private void Calc_File_Hash_button_Click(object sender, EventArgs e)
        {
            if (file_exist_check())
            {
                try
                {
                    using (FileStream fs = File.OpenRead(choosePath))
                    {
                        Hash_textBox.Text = Get_SHA3_Hash(fs);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка");
                }
                result_label_reset();
            }
        }

        private void Calc_File_Hash_with_key_button_Click(object sender, EventArgs e)
        {
            if (key_not_empty_Check() && file_exist_check())
            {
                try
                {
                    using (FileStream fs = File.OpenRead(choosePath))
                    {
                        Hash_textBox.Text = Get_HMAC_SHA3_Hash(fs, key);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка");
                }
                result_label_reset();
            }
        }

        private void Check_File_Hash_button_Click(object sender, EventArgs e)
        {
            if (file_exist_check())
            {
                try
                {
                    using (FileStream fs = File.OpenRead(choosePath))
                    {
                        Hash_compare(Get_SHA3_Hash(fs));
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка");
                }
            }
        }

        private void button_Check_File_Hash_with_key_Click(object sender, EventArgs e)
        {
            if (key_not_empty_Check() && file_exist_check())
            {
                try
                {
                    using (FileStream fs = File.OpenRead(choosePath))
                    {
                        Hash_compare(Get_HMAC_SHA3_Hash(fs, key));
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка");
                }
            }
        }

        private bool file_exist_check()
        {
            if (File.Exists(choosePath))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Файл не существует!");
                return false;
            }
        }

        private bool key_not_empty_Check()
        {
            if (!String.IsNullOrEmpty(key))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Сначала нужно ввести парольную фразу!");
                KeyInput keyInput = new KeyInput();
                keyInput.ShowDialog();
                return false;
            }
        }

        private void Hash_compare(string hash)
        {
            if (Hash_textBox.Text == hash)
            {
                label_Result.ForeColor = Color.Green;
                label_Result.Text = "Хеши совпадают.";
            }
            else
            {
                label_Result.ForeColor = Color.Red;
                label_Result.Text = "Хеши НЕ совпадают.";
            }
        }

        private void result_label_reset()
        {
            label_Result.ForeColor = Color.Black;
            label_Result.Text = "Хеш:";
        }

        private void FileMod(bool on)
        {
            //File mode
            FileModeToolStripMenuItem.Checked = on;
            textBox_Choose_File_Path.Visible = on;
            Calc_File_Hash_button.Visible = on;
            Calc_File_Hash_with_key_button.Visible = on;
            Check_File_Hash_button.Visible = on;
            button_Check_File_Hash_with_key.Visible = on;
            if (on) Choose_File_label.Text = "Путь к файлу:";
            else Choose_File_label.Text = "Текст:";
            //Text mode
            TextModeToolStripMenuItem.Checked = !on;
            checkBox_HEX.Visible = !on;
            Text_textBox.Visible = !on;
            Calc_Text_Hash_button.Visible = !on;
            Calc_Text_Hash_with_key_button.Visible = !on;
            Check_Text_Hash_button.Visible = !on;
            button_Check_Text_Hash_with_key.Visible = !on;
            
        }

        public static string Get_SHA3_Hash(string Text, bool Is_HEX_Input)
        {
            if (!Is_HEX_Input)
                switch (hashFunction)
                {
                    case "SHA3-512":
                        return SHA3.SHA3_512(Text);
                    case "SHA3-384":
                        return SHA3.SHA3_384(Text);
                    case "SHA3-256":
                        return SHA3.SHA3_256(Text);
                    case "SHA3-224":
                        return SHA3.SHA3_224(Text);
                }
            else
                switch (hashFunction)
                {
                    case "SHA3-512":
                        return SHA3.SHA3_512_HEX(Text);
                    case "SHA3-384":
                        return SHA3.SHA3_384_HEX(Text);
                    case "SHA3-256":
                        return SHA3.SHA3_256_HEX(Text);
                    case "SHA3-224":
                        return SHA3.SHA3_224_HEX(Text);
                }
            return "Error in switching.";
        }

        public static string Get_HMAC_SHA3_Hash(string Text, string Key, bool Is_HEX_Input)
        {
            if (!Is_HEX_Input)
                switch (hashFunction)
                {
                    case "SHA3-512":
                        return SHA3.SHA3_HMAC_512(Text, Key);
                    case "SHA3-384":
                        return SHA3.SHA3_HMAC_384(Text, Key);
                    case "SHA3-256":
                        return SHA3.SHA3_HMAC_256(Text, Key);
                    case "SHA3-224":
                        return SHA3.SHA3_HMAC_224(Text, Key);
                }
            else
                switch (hashFunction)
                {
                    case "SHA3-512":
                        return SHA3.SHA3_HMAC_512_HEX(Text, Key);
                    case "SHA3-384":
                        return SHA3.SHA3_HMAC_384_HEX(Text, Key);
                    case "SHA3-256":
                        return SHA3.SHA3_HMAC_256_HEX(Text, Key);
                    case "SHA3-224":
                        return SHA3.SHA3_HMAC_224_HEX(Text, Key);
                }
            return "Error in switching.";
        }

        public static string Get_SHA3_Hash(FileStream fs)
        {
            switch (hashFunction)
            {
                case "SHA3-512":
                    return SHA3.SHA3_512(fs);
                case "SHA3-384":
                    return SHA3.SHA3_384(fs);
                case "SHA3-256":
                    return SHA3.SHA3_256(fs);
                case "SHA3-224":
                    return SHA3.SHA3_224(fs);
            }
            return "Error in switching.";
        }

        public static string Get_HMAC_SHA3_Hash(FileStream fs, string Key)
        {
            switch (hashFunction)
            {
                case "SHA3-512":
                    return SHA3.SHA3_HMAC_512(fs, Key);
                case "SHA3-384":
                    return SHA3.SHA3_HMAC_384(fs, Key);
                case "SHA3-256":
                    return SHA3.SHA3_HMAC_256(fs, Key);
                case "SHA3-224":
                    return SHA3.SHA3_HMAC_224(fs, Key);
            }
            return "Error in switching.";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (File.Exists(settingsPath))
                    File.SetAttributes(settingsPath, FileAttributes.Normal);
                using (FileStream fs = new FileStream(settingsPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, keyRestrict);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не удалось сохранить настройки.\n" + exc.Message, "Ошибка");
            }
        }
    }
}
