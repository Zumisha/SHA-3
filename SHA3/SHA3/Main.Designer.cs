namespace SHA3
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenHashFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsHashFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьТекстИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьТекстВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyConstraintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцияХешированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_Hash_Func_Choose = new System.Windows.Forms.ToolStripComboBox();
            this.ReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_textBox = new System.Windows.Forms.TextBox();
            this.Hash_textBox = new System.Windows.Forms.TextBox();
            this.Calc_File_Hash_button = new System.Windows.Forms.Button();
            this.Choose_File_label = new System.Windows.Forms.Label();
            this.textBox_Choose_File_Path = new System.Windows.Forms.TextBox();
            this.Check_File_Hash_button = new System.Windows.Forms.Button();
            this.Calc_File_Hash_with_key_button = new System.Windows.Forms.Button();
            this.label_Result = new System.Windows.Forms.Label();
            this.Check_Text_Hash_button = new System.Windows.Forms.Button();
            this.Calc_Text_Hash_button = new System.Windows.Forms.Button();
            this.Calc_Text_Hash_with_key_button = new System.Windows.Forms.Button();
            this.button_Check_File_Hash_with_key = new System.Windows.Forms.Button();
            this.button_Check_Text_Hash_with_key = new System.Windows.Forms.Button();
            this.button_key_input = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBox_HEX = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.ReferenceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(784, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenHashFileToolStripMenuItem,
            this.SaveAsHashFileToolStripMenuItem,
            this.открытьТекстИзФайлаToolStripMenuItem,
            this.сохранитьТекстВФайлToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenHashFileToolStripMenuItem
            // 
            this.OpenHashFileToolStripMenuItem.Name = "OpenHashFileToolStripMenuItem";
            this.OpenHashFileToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.OpenHashFileToolStripMenuItem.Text = "Открыть файл с хешем";
            this.OpenHashFileToolStripMenuItem.Click += new System.EventHandler(this.OpenHashFileToolStripMenuItem_Click);
            // 
            // SaveAsHashFileToolStripMenuItem
            // 
            this.SaveAsHashFileToolStripMenuItem.Name = "SaveAsHashFileToolStripMenuItem";
            this.SaveAsHashFileToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.SaveAsHashFileToolStripMenuItem.Text = "Сохранить хеш в файл";
            this.SaveAsHashFileToolStripMenuItem.Click += new System.EventHandler(this.SaveAsHashFileToolStripMenuItem_Click);
            // 
            // открытьТекстИзФайлаToolStripMenuItem
            // 
            this.открытьТекстИзФайлаToolStripMenuItem.Name = "открытьТекстИзФайлаToolStripMenuItem";
            this.открытьТекстИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.открытьТекстИзФайлаToolStripMenuItem.Text = "Открыть текстовый файл";
            this.открытьТекстИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.открытьТекстИзФайлаToolStripMenuItem_Click);
            // 
            // сохранитьТекстВФайлToolStripMenuItem
            // 
            this.сохранитьТекстВФайлToolStripMenuItem.Name = "сохранитьТекстВФайлToolStripMenuItem";
            this.сохранитьТекстВФайлToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.сохранитьТекстВФайлToolStripMenuItem.Text = "Сохранить текст в файл";
            this.сохранитьТекстВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьТекстВФайлToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperationModeToolStripMenuItem,
            this.KeyConstraintsToolStripMenuItem,
            this.функцияХешированияToolStripMenuItem});
            this.ViewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.ViewToolStripMenuItem.Text = "Настройки";
            // 
            // OperationModeToolStripMenuItem
            // 
            this.OperationModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextModeToolStripMenuItem,
            this.FileModeToolStripMenuItem});
            this.OperationModeToolStripMenuItem.Name = "OperationModeToolStripMenuItem";
            this.OperationModeToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.OperationModeToolStripMenuItem.Text = "Режим работы";
            // 
            // TextModeToolStripMenuItem
            // 
            this.TextModeToolStripMenuItem.Checked = true;
            this.TextModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TextModeToolStripMenuItem.Name = "TextModeToolStripMenuItem";
            this.TextModeToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.TextModeToolStripMenuItem.Text = "Текстовый";
            this.TextModeToolStripMenuItem.Click += new System.EventHandler(this.TextModeToolStripMenuItem_Click);
            // 
            // FileModeToolStripMenuItem
            // 
            this.FileModeToolStripMenuItem.Name = "FileModeToolStripMenuItem";
            this.FileModeToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.FileModeToolStripMenuItem.Text = "Файловый";
            this.FileModeToolStripMenuItem.Click += new System.EventHandler(this.FileModeToolStripMenuItem_Click);
            // 
            // KeyConstraintsToolStripMenuItem
            // 
            this.KeyConstraintsToolStripMenuItem.Name = "KeyConstraintsToolStripMenuItem";
            this.KeyConstraintsToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.KeyConstraintsToolStripMenuItem.Text = "Ограничения на ключ";
            this.KeyConstraintsToolStripMenuItem.Click += new System.EventHandler(this.KeyConstraintsToolStripMenuItem_Click);
            // 
            // функцияХешированияToolStripMenuItem
            // 
            this.функцияХешированияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_Hash_Func_Choose});
            this.функцияХешированияToolStripMenuItem.Name = "функцияХешированияToolStripMenuItem";
            this.функцияХешированияToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.функцияХешированияToolStripMenuItem.Text = "Функция хеширования";
            // 
            // toolStripComboBox_Hash_Func_Choose
            // 
            this.toolStripComboBox_Hash_Func_Choose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripComboBox_Hash_Func_Choose.Items.AddRange(new object[] {
            "SHA3-512",
            "SHA3-384",
            "SHA3-256",
            "SHA3-224"});
            this.toolStripComboBox_Hash_Func_Choose.Name = "toolStripComboBox_Hash_Func_Choose";
            this.toolStripComboBox_Hash_Func_Choose.Size = new System.Drawing.Size(121, 29);
            this.toolStripComboBox_Hash_Func_Choose.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_Hash_Func_Choose_SelectedIndexChanged);
            // 
            // ReferenceToolStripMenuItem
            // 
            this.ReferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.ReferenceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem";
            this.ReferenceToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.ReferenceToolStripMenuItem.Text = "Справка";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Text_textBox
            // 
            this.Text_textBox.Location = new System.Drawing.Point(13, 72);
            this.Text_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text_textBox.MaxLength = 32500;
            this.Text_textBox.Multiline = true;
            this.Text_textBox.Name = "Text_textBox";
            this.Text_textBox.Size = new System.Drawing.Size(758, 159);
            this.Text_textBox.TabIndex = 1;
            // 
            // Hash_textBox
            // 
            this.Hash_textBox.Location = new System.Drawing.Point(13, 382);
            this.Hash_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hash_textBox.MaxLength = 128;
            this.Hash_textBox.Multiline = true;
            this.Hash_textBox.Name = "Hash_textBox";
            this.Hash_textBox.Size = new System.Drawing.Size(758, 46);
            this.Hash_textBox.TabIndex = 2;
            this.Hash_textBox.Text = "\r\n";
            // 
            // Calc_File_Hash_button
            // 
            this.Calc_File_Hash_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calc_File_Hash_button.Location = new System.Drawing.Point(12, 239);
            this.Calc_File_Hash_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Calc_File_Hash_button.Name = "Calc_File_Hash_button";
            this.Calc_File_Hash_button.Size = new System.Drawing.Size(300, 48);
            this.Calc_File_Hash_button.TabIndex = 4;
            this.Calc_File_Hash_button.Text = "Вычислить хеш выбранного файла";
            this.Calc_File_Hash_button.UseVisualStyleBackColor = true;
            this.Calc_File_Hash_button.Visible = false;
            this.Calc_File_Hash_button.Click += new System.EventHandler(this.Calc_File_Hash_button_Click);
            // 
            // Choose_File_label
            // 
            this.Choose_File_label.AutoSize = true;
            this.Choose_File_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choose_File_label.Location = new System.Drawing.Point(13, 39);
            this.Choose_File_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Choose_File_label.Name = "Choose_File_label";
            this.Choose_File_label.Size = new System.Drawing.Size(112, 20);
            this.Choose_File_label.TabIndex = 7;
            this.Choose_File_label.Text = "Путь к файлу";
            // 
            // textBox_Choose_File_Path
            // 
            this.textBox_Choose_File_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Choose_File_Path.Location = new System.Drawing.Point(133, 36);
            this.textBox_Choose_File_Path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Choose_File_Path.Name = "textBox_Choose_File_Path";
            this.textBox_Choose_File_Path.ReadOnly = true;
            this.textBox_Choose_File_Path.Size = new System.Drawing.Size(638, 26);
            this.textBox_Choose_File_Path.TabIndex = 6;
            this.textBox_Choose_File_Path.Visible = false;
            this.textBox_Choose_File_Path.Click += new System.EventHandler(this.Choose_File_Path_Click);
            // 
            // Check_File_Hash_button
            // 
            this.Check_File_Hash_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check_File_Hash_button.Location = new System.Drawing.Point(13, 303);
            this.Check_File_Hash_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Check_File_Hash_button.Name = "Check_File_Hash_button";
            this.Check_File_Hash_button.Size = new System.Drawing.Size(300, 48);
            this.Check_File_Hash_button.TabIndex = 8;
            this.Check_File_Hash_button.Text = "Проверить контрольное хеш-значение выбранного файла";
            this.Check_File_Hash_button.UseVisualStyleBackColor = true;
            this.Check_File_Hash_button.Visible = false;
            this.Check_File_Hash_button.Click += new System.EventHandler(this.Check_File_Hash_button_Click);
            // 
            // Calc_File_Hash_with_key_button
            // 
            this.Calc_File_Hash_with_key_button.Location = new System.Drawing.Point(470, 239);
            this.Calc_File_Hash_with_key_button.Name = "Calc_File_Hash_with_key_button";
            this.Calc_File_Hash_with_key_button.Size = new System.Drawing.Size(300, 48);
            this.Calc_File_Hash_with_key_button.TabIndex = 12;
            this.Calc_File_Hash_with_key_button.Text = "Вычислить хеш выбранного файла\r\nс использованием парольной фразы";
            this.Calc_File_Hash_with_key_button.UseVisualStyleBackColor = true;
            this.Calc_File_Hash_with_key_button.Click += new System.EventHandler(this.Calc_File_Hash_with_key_button_Click);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(12, 357);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(46, 20);
            this.label_Result.TabIndex = 13;
            this.label_Result.Text = "Хеш:";
            // 
            // Check_Text_Hash_button
            // 
            this.Check_Text_Hash_button.Location = new System.Drawing.Point(18, 303);
            this.Check_Text_Hash_button.Name = "Check_Text_Hash_button";
            this.Check_Text_Hash_button.Size = new System.Drawing.Size(300, 48);
            this.Check_Text_Hash_button.TabIndex = 14;
            this.Check_Text_Hash_button.Text = "Проверить контрольное хеш-значение текста";
            this.Check_Text_Hash_button.UseVisualStyleBackColor = true;
            this.Check_Text_Hash_button.Click += new System.EventHandler(this.Check_Text_Hash_button_Click);
            // 
            // Calc_Text_Hash_button
            // 
            this.Calc_Text_Hash_button.Location = new System.Drawing.Point(18, 239);
            this.Calc_Text_Hash_button.Name = "Calc_Text_Hash_button";
            this.Calc_Text_Hash_button.Size = new System.Drawing.Size(300, 48);
            this.Calc_Text_Hash_button.TabIndex = 15;
            this.Calc_Text_Hash_button.Text = "Вычислить хеш текста";
            this.Calc_Text_Hash_button.UseVisualStyleBackColor = true;
            this.Calc_Text_Hash_button.Click += new System.EventHandler(this.Calc_Text_Hash_button_Click);
            // 
            // Calc_Text_Hash_with_key_button
            // 
            this.Calc_Text_Hash_with_key_button.Location = new System.Drawing.Point(465, 239);
            this.Calc_Text_Hash_with_key_button.Name = "Calc_Text_Hash_with_key_button";
            this.Calc_Text_Hash_with_key_button.Size = new System.Drawing.Size(300, 48);
            this.Calc_Text_Hash_with_key_button.TabIndex = 16;
            this.Calc_Text_Hash_with_key_button.Text = "Вычислить хеш текста\r\nс использованием парольной фразы";
            this.Calc_Text_Hash_with_key_button.UseVisualStyleBackColor = true;
            this.Calc_Text_Hash_with_key_button.Click += new System.EventHandler(this.Calc_Text_Hash_with_key_button_Click);
            // 
            // button_Check_File_Hash_with_key
            // 
            this.button_Check_File_Hash_with_key.Location = new System.Drawing.Point(470, 303);
            this.button_Check_File_Hash_with_key.Name = "button_Check_File_Hash_with_key";
            this.button_Check_File_Hash_with_key.Size = new System.Drawing.Size(300, 70);
            this.button_Check_File_Hash_with_key.TabIndex = 17;
            this.button_Check_File_Hash_with_key.Text = "Проверить контрольное хеш-значение выбранного файла с использованием парольной фр" +
    "азы";
            this.button_Check_File_Hash_with_key.UseVisualStyleBackColor = true;
            this.button_Check_File_Hash_with_key.Click += new System.EventHandler(this.button_Check_File_Hash_with_key_Click);
            // 
            // button_Check_Text_Hash_with_key
            // 
            this.button_Check_Text_Hash_with_key.Location = new System.Drawing.Point(465, 303);
            this.button_Check_Text_Hash_with_key.Name = "button_Check_Text_Hash_with_key";
            this.button_Check_Text_Hash_with_key.Size = new System.Drawing.Size(300, 71);
            this.button_Check_Text_Hash_with_key.TabIndex = 18;
            this.button_Check_Text_Hash_with_key.Text = "Проверить контрольное хеш-значение текста с использованием парольной фразы";
            this.button_Check_Text_Hash_with_key.UseVisualStyleBackColor = true;
            this.button_Check_Text_Hash_with_key.Click += new System.EventHandler(this.button_Check_Text_Hash_with_key_Click);
            // 
            // button_key_input
            // 
            this.button_key_input.Location = new System.Drawing.Point(324, 239);
            this.button_key_input.Name = "button_key_input";
            this.button_key_input.Size = new System.Drawing.Size(135, 134);
            this.button_key_input.TabIndex = 19;
            this.button_key_input.Text = "Ввести парольную фразу";
            this.button_key_input.UseVisualStyleBackColor = true;
            this.button_key_input.Click += new System.EventHandler(this.button_key_input_Click);
            // 
            // checkBox_HEX
            // 
            this.checkBox_HEX.AutoSize = true;
            this.checkBox_HEX.Location = new System.Drawing.Point(611, 40);
            this.checkBox_HEX.Name = "checkBox_HEX";
            this.checkBox_HEX.Size = new System.Drawing.Size(161, 24);
            this.checkBox_HEX.TabIndex = 20;
            this.checkBox_HEX.Text = "16-ричная строка";
            this.checkBox_HEX.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.checkBox_HEX);
            this.Controls.Add(this.button_key_input);
            this.Controls.Add(this.button_Check_Text_Hash_with_key);
            this.Controls.Add(this.button_Check_File_Hash_with_key);
            this.Controls.Add(this.Calc_Text_Hash_with_key_button);
            this.Controls.Add(this.Calc_Text_Hash_button);
            this.Controls.Add(this.Check_Text_Hash_button);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.Calc_File_Hash_with_key_button);
            this.Controls.Add(this.Check_File_Hash_button);
            this.Controls.Add(this.Choose_File_label);
            this.Controls.Add(this.textBox_Choose_File_Path);
            this.Controls.Add(this.Calc_File_Hash_button);
            this.Controls.Add(this.Hash_textBox);
            this.Controls.Add(this.Text_textBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Main";
            this.Text = "Программная реализация SHA-3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenHashFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TextBox Text_textBox;
        private System.Windows.Forms.TextBox Hash_textBox;
        private System.Windows.Forms.Button Calc_File_Hash_button;
        private System.Windows.Forms.ToolStripMenuItem SaveAsHashFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TextModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileModeToolStripMenuItem;
        private System.Windows.Forms.Label Choose_File_label;
        private System.Windows.Forms.TextBox textBox_Choose_File_Path;
        private System.Windows.Forms.Button Check_File_Hash_button;
        private System.Windows.Forms.ToolStripMenuItem KeyConstraintsToolStripMenuItem;
        private System.Windows.Forms.Button Calc_File_Hash_with_key_button;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button Check_Text_Hash_button;
        private System.Windows.Forms.Button Calc_Text_Hash_button;
        private System.Windows.Forms.Button Calc_Text_Hash_with_key_button;
        private System.Windows.Forms.Button button_Check_File_Hash_with_key;
        private System.Windows.Forms.Button button_Check_Text_Hash_with_key;
        private System.Windows.Forms.Button button_key_input;
        private System.Windows.Forms.ToolStripMenuItem открытьТекстИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьТекстВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функцияХешированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Hash_Func_Choose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBox_HEX;
    }
}

