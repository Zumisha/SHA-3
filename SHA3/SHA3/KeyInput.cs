using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA3
{
    public partial class KeyInput : Form
    {
        string s, l;
        public KeyInput()
        {
            InitializeComponent();
        }

        private void Cancel_Key_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ok_Key_button_Click(object sender, EventArgs e)
        {
            if (Pass_is_good(Pass_Key_textBox.Text))
            {
                if (Pass_Key_textBox.Text == textBox_confirm.Text)
                {
                    Main.key = Main.Get_SHA3_Hash(Pass_Key_textBox.Text, false);
                    Close();
                }
                else
                {
                    label_err.Text = "Парольная фраза и подтверждение не совпадают!";
                }
            }
            else
            {
                l = "";
                if (Main.keyRestrict.Min_length != 0)
                {
                    l = " больше " + Main.keyRestrict.Min_length;
                    s = Main.keyRestrict.Min_length.ToString();
                    if (s.Substring(s.Length - 1) == "1") l += " символа,";
                    else l += " символов,";
                }
                if (Main.keyRestrict.Max_length != 0)
                {
                    l += " меньше " + Main.keyRestrict.Max_length;
                    s = Main.keyRestrict.Max_length.ToString();
                    if (s.Substring(s.Length - 1) == "1") l += " символа,";
                    else l += " символов,";
                }
                if (Main.keyRestrict.Numbers) l += " цифры,";
                if (Main.keyRestrict.Capitals) l += " заглавные буквы,";
                if (Main.keyRestrict.Lowercase) l += " строчные буквы,";
                if (Main.keyRestrict.Special_chars) l += " специальные символы,";
                label_err.Text = "Парольная фраза должна содержать" + l.Substring(0, l.Length - 1) + "!";
            }
        }

        private bool Pass_is_good(string pass)
        {
            if (pass.Length < Main.keyRestrict.Min_length ||
                Main.keyRestrict.Max_length != 0 && pass.Length > Main.keyRestrict.Max_length ||
                Main.keyRestrict.Lowercase && !pass.Any(c => char.IsLower(c)) ||
                Main.keyRestrict.Numbers && !pass.Any(c => char.IsNumber(c)) ||
                Main.keyRestrict.Capitals && !pass.Any(c => char.IsUpper(c)) ||
                Main.keyRestrict.Special_chars && !pass.Any(c => char.IsSymbol(c)))
                return false;
            return true;
        }

        private void Pass_Key_checkBox_Click(object sender, EventArgs e)
        {
            if (Pass_Key_checkBox.Checked)
            {
                Pass_Key_textBox.PasswordChar = '\0';
                textBox_confirm.PasswordChar = '\0';
            }
            else
            {
                Pass_Key_textBox.PasswordChar = '*';
                textBox_confirm.PasswordChar = '*';
            }
        }
    }
}
