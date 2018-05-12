namespace SHA3
{
    partial class KeyInput
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
            this.Pass_Key_checkBox = new System.Windows.Forms.CheckBox();
            this.Pass_Key_textBox = new System.Windows.Forms.TextBox();
            this.Ok_Pass_Key_button = new System.Windows.Forms.Button();
            this.Cancel_Pass_Key_button = new System.Windows.Forms.Button();
            this.label_err = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_confirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Pass_Key_checkBox
            // 
            this.Pass_Key_checkBox.AutoSize = true;
            this.Pass_Key_checkBox.Location = new System.Drawing.Point(344, 127);
            this.Pass_Key_checkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pass_Key_checkBox.Name = "Pass_Key_checkBox";
            this.Pass_Key_checkBox.Size = new System.Drawing.Size(144, 24);
            this.Pass_Key_checkBox.TabIndex = 14;
            this.Pass_Key_checkBox.Text = "Показать ключ";
            this.Pass_Key_checkBox.UseVisualStyleBackColor = true;
            this.Pass_Key_checkBox.Click += new System.EventHandler(this.Pass_Key_checkBox_Click);
            // 
            // Pass_Key_textBox
            // 
            this.Pass_Key_textBox.Location = new System.Drawing.Point(167, 14);
            this.Pass_Key_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pass_Key_textBox.Name = "Pass_Key_textBox";
            this.Pass_Key_textBox.PasswordChar = '*';
            this.Pass_Key_textBox.Size = new System.Drawing.Size(624, 26);
            this.Pass_Key_textBox.TabIndex = 13;
            // 
            // Ok_Pass_Key_button
            // 
            this.Ok_Pass_Key_button.Location = new System.Drawing.Point(709, 122);
            this.Ok_Pass_Key_button.Name = "Ok_Pass_Key_button";
            this.Ok_Pass_Key_button.Size = new System.Drawing.Size(83, 33);
            this.Ok_Pass_Key_button.TabIndex = 15;
            this.Ok_Pass_Key_button.Text = "Принять";
            this.Ok_Pass_Key_button.UseVisualStyleBackColor = true;
            this.Ok_Pass_Key_button.Click += new System.EventHandler(this.Ok_Key_button_Click);
            // 
            // Cancel_Pass_Key_button
            // 
            this.Cancel_Pass_Key_button.Location = new System.Drawing.Point(14, 122);
            this.Cancel_Pass_Key_button.Name = "Cancel_Pass_Key_button";
            this.Cancel_Pass_Key_button.Size = new System.Drawing.Size(89, 33);
            this.Cancel_Pass_Key_button.TabIndex = 16;
            this.Cancel_Pass_Key_button.Text = "Отмена";
            this.Cancel_Pass_Key_button.UseVisualStyleBackColor = true;
            this.Cancel_Pass_Key_button.Click += new System.EventHandler(this.Cancel_Key_button_Click);
            // 
            // label_err
            // 
            this.label_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_err.ForeColor = System.Drawing.Color.Red;
            this.label_err.Location = new System.Drawing.Point(13, 77);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(779, 42);
            this.label_err.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Парольная фраза";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Подтверждение";
            // 
            // textBox_confirm
            // 
            this.textBox_confirm.Location = new System.Drawing.Point(167, 48);
            this.textBox_confirm.Name = "textBox_confirm";
            this.textBox_confirm.PasswordChar = '*';
            this.textBox_confirm.Size = new System.Drawing.Size(625, 26);
            this.textBox_confirm.TabIndex = 20;
            // 
            // KeyInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 167);
            this.Controls.Add(this.textBox_confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_err);
            this.Controls.Add(this.Cancel_Pass_Key_button);
            this.Controls.Add(this.Ok_Pass_Key_button);
            this.Controls.Add(this.Pass_Key_checkBox);
            this.Controls.Add(this.Pass_Key_textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KeyInput";
            this.Text = "Введите парольную фразу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Pass_Key_checkBox;
        private System.Windows.Forms.TextBox Pass_Key_textBox;
        private System.Windows.Forms.Button Ok_Pass_Key_button;
        private System.Windows.Forms.Button Cancel_Pass_Key_button;
        private System.Windows.Forms.Label label_err;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_confirm;
    }
}