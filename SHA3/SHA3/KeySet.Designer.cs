namespace SHA3
{
    partial class KeySet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_min_length = new System.Windows.Forms.TextBox();
            this.textBox_max_length = new System.Windows.Forms.TextBox();
            this.checkBox_Numbers = new System.Windows.Forms.CheckBox();
            this.checkBox_lowercase = new System.Windows.Forms.CheckBox();
            this.checkBox_capitals = new System.Windows.Forms.CheckBox();
            this.checkBox_spec_chars = new System.Windows.Forms.CheckBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Минимальная длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Максимальная длина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наличие цифр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Наличие строчных букв";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Наличие заглавных букв";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Наличие спецсимволов";
            // 
            // textBox_min_length
            // 
            this.textBox_min_length.Location = new System.Drawing.Point(214, 12);
            this.textBox_min_length.Name = "textBox_min_length";
            this.textBox_min_length.Size = new System.Drawing.Size(128, 26);
            this.textBox_min_length.TabIndex = 6;
            this.textBox_min_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_min_length_KeyPress);
            // 
            // textBox_max_length
            // 
            this.textBox_max_length.Location = new System.Drawing.Point(214, 44);
            this.textBox_max_length.Name = "textBox_max_length";
            this.textBox_max_length.Size = new System.Drawing.Size(128, 26);
            this.textBox_max_length.TabIndex = 7;
            this.textBox_max_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_max_length_KeyPress);
            // 
            // checkBox_Numbers
            // 
            this.checkBox_Numbers.AutoSize = true;
            this.checkBox_Numbers.Location = new System.Drawing.Point(214, 84);
            this.checkBox_Numbers.Name = "checkBox_Numbers";
            this.checkBox_Numbers.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Numbers.TabIndex = 8;
            this.checkBox_Numbers.UseVisualStyleBackColor = true;
            // 
            // checkBox_lowercase
            // 
            this.checkBox_lowercase.AutoSize = true;
            this.checkBox_lowercase.Location = new System.Drawing.Point(214, 112);
            this.checkBox_lowercase.Name = "checkBox_lowercase";
            this.checkBox_lowercase.Size = new System.Drawing.Size(15, 14);
            this.checkBox_lowercase.TabIndex = 9;
            this.checkBox_lowercase.UseVisualStyleBackColor = true;
            // 
            // checkBox_capitals
            // 
            this.checkBox_capitals.AutoSize = true;
            this.checkBox_capitals.Location = new System.Drawing.Point(214, 140);
            this.checkBox_capitals.Name = "checkBox_capitals";
            this.checkBox_capitals.Size = new System.Drawing.Size(15, 14);
            this.checkBox_capitals.TabIndex = 10;
            this.checkBox_capitals.UseVisualStyleBackColor = true;
            // 
            // checkBox_spec_chars
            // 
            this.checkBox_spec_chars.AutoSize = true;
            this.checkBox_spec_chars.Location = new System.Drawing.Point(214, 170);
            this.checkBox_spec_chars.Name = "checkBox_spec_chars";
            this.checkBox_spec_chars.Size = new System.Drawing.Size(15, 14);
            this.checkBox_spec_chars.TabIndex = 11;
            this.checkBox_spec_chars.UseVisualStyleBackColor = true;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(257, 190);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(85, 29);
            this.button_Ok.TabIndex = 12;
            this.button_Ok.Text = "Принять";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(12, 190);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(81, 29);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // KeySet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 231);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.checkBox_spec_chars);
            this.Controls.Add(this.checkBox_capitals);
            this.Controls.Add(this.checkBox_lowercase);
            this.Controls.Add(this.checkBox_Numbers);
            this.Controls.Add(this.textBox_max_length);
            this.Controls.Add(this.textBox_min_length);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KeySet";
            this.Text = "Ограничения парольной фразы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_min_length;
        private System.Windows.Forms.TextBox textBox_max_length;
        private System.Windows.Forms.CheckBox checkBox_Numbers;
        private System.Windows.Forms.CheckBox checkBox_lowercase;
        private System.Windows.Forms.CheckBox checkBox_capitals;
        private System.Windows.Forms.CheckBox checkBox_spec_chars;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
    }
}