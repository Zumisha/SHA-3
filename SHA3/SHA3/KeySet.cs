using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class KeySet : Form
    {
        private UInt16 min, max;
        public KeySet()
        {
            InitializeComponent();
            textBox_min_length.Text = Main.keyRestrict.Min_length.ToString();
            textBox_max_length.Text = Main.keyRestrict.Max_length.ToString();
            checkBox_capitals.Checked = Main.keyRestrict.Capitals;
            checkBox_lowercase.Checked = Main.keyRestrict.Lowercase;
            checkBox_Numbers.Checked = Main.keyRestrict.Numbers;
            checkBox_spec_chars.Checked = Main.keyRestrict.Special_chars;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_min_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && (e.KeyChar < '0' || e.KeyChar > '9'))
                e.KeyChar = '\0';
        }

        private void textBox_max_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && (e.KeyChar < '0' || e.KeyChar > '9'))
                e.KeyChar = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                min = Convert.ToUInt16(textBox_min_length.Text);
            }
            catch (Exception)
            {
                min = 0;
            }
            try
            {
                max = Convert.ToUInt16(textBox_max_length.Text);
            }
            catch (Exception)
            {
                max = 0;
            }
            if (max < min)
            {
                max = min;
            }
            Main.keyRestrict = new KeyRestrict(min, max, checkBox_Numbers.Checked, checkBox_lowercase.Checked, checkBox_capitals.Checked, checkBox_spec_chars.Checked);
            Close();
        }
    }
}