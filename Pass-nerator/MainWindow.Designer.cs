namespace Pass_nerator
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.getPasswordButton = new System.Windows.Forms.Button();
			this.titleLabel = new System.Windows.Forms.Label();
			this.numbersInTheEndCheckBox = new System.Windows.Forms.CheckBox();
			this.lettersOnlyRadioButton = new System.Windows.Forms.RadioButton();
			this.numbersOnlyRadioButton = new System.Windows.Forms.RadioButton();
			this.lettersAndNumbersRadioButton = new System.Windows.Forms.RadioButton();
			this.keyWordRadioButton = new System.Windows.Forms.RadioButton();
			this.countOfSymbolsTextBox = new System.Windows.Forms.TextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.countOfSymbolsLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.russianRadioButton = new System.Windows.Forms.RadioButton();
			this.englishRadioButton = new System.Windows.Forms.RadioButton();
			this.keyWordTextBox = new System.Windows.Forms.TextBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.collapseButton = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.подключитьКодовыеСловаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.getRandomKeyWord = new System.Windows.Forms.Button();
			this.copyButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.countOfKeyWords = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// getPasswordButton
			// 
			this.getPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.getPasswordButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.getPasswordButton.Location = new System.Drawing.Point(251, 305);
			this.getPasswordButton.Name = "getPasswordButton";
			this.getPasswordButton.Size = new System.Drawing.Size(148, 48);
			this.getPasswordButton.TabIndex = 0;
			this.getPasswordButton.Text = "Получить пароль";
			this.getPasswordButton.UseVisualStyleBackColor = true;
			this.getPasswordButton.Click += new System.EventHandler(this.getPasswordButton_Click);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.BackColor = System.Drawing.Color.Transparent;
			this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.titleLabel.ForeColor = System.Drawing.Color.Red;
			this.titleLabel.Location = new System.Drawing.Point(205, 24);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(229, 47);
			this.titleLabel.TabIndex = 1;
			this.titleLabel.Text = "Pass-nerator";
			// 
			// numbersInTheEndCheckBox
			// 
			this.numbersInTheEndCheckBox.AutoSize = true;
			this.numbersInTheEndCheckBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numbersInTheEndCheckBox.Location = new System.Drawing.Point(402, 151);
			this.numbersInTheEndCheckBox.Name = "numbersInTheEndCheckBox";
			this.numbersInTheEndCheckBox.Size = new System.Drawing.Size(117, 19);
			this.numbersInTheEndCheckBox.TabIndex = 2;
			this.numbersInTheEndCheckBox.Text = "Цифры в конце";
			this.numbersInTheEndCheckBox.UseVisualStyleBackColor = true;
			// 
			// lettersOnlyRadioButton
			// 
			this.lettersOnlyRadioButton.AutoSize = true;
			this.lettersOnlyRadioButton.Location = new System.Drawing.Point(6, 12);
			this.lettersOnlyRadioButton.Name = "lettersOnlyRadioButton";
			this.lettersOnlyRadioButton.Size = new System.Drawing.Size(109, 19);
			this.lettersOnlyRadioButton.TabIndex = 3;
			this.lettersOnlyRadioButton.TabStop = true;
			this.lettersOnlyRadioButton.Text = "Только буквы";
			this.lettersOnlyRadioButton.UseVisualStyleBackColor = true;
			this.lettersOnlyRadioButton.CheckedChanged += new System.EventHandler(this.lettersOnlyRadioButton_CheckedChanged);
			// 
			// numbersOnlyRadioButton
			// 
			this.numbersOnlyRadioButton.AutoSize = true;
			this.numbersOnlyRadioButton.Location = new System.Drawing.Point(6, 35);
			this.numbersOnlyRadioButton.Name = "numbersOnlyRadioButton";
			this.numbersOnlyRadioButton.Size = new System.Drawing.Size(109, 19);
			this.numbersOnlyRadioButton.TabIndex = 4;
			this.numbersOnlyRadioButton.TabStop = true;
			this.numbersOnlyRadioButton.Text = "Только цифры";
			this.numbersOnlyRadioButton.UseVisualStyleBackColor = true;
			this.numbersOnlyRadioButton.CheckedChanged += new System.EventHandler(this.numbersOnlyRadioButton_CheckedChanged);
			// 
			// lettersAndNumbersRadioButton
			// 
			this.lettersAndNumbersRadioButton.AutoSize = true;
			this.lettersAndNumbersRadioButton.Location = new System.Drawing.Point(6, 58);
			this.lettersAndNumbersRadioButton.Name = "lettersAndNumbersRadioButton";
			this.lettersAndNumbersRadioButton.Size = new System.Drawing.Size(116, 19);
			this.lettersAndNumbersRadioButton.TabIndex = 5;
			this.lettersAndNumbersRadioButton.TabStop = true;
			this.lettersAndNumbersRadioButton.Text = "Цифры и буквы";
			this.lettersAndNumbersRadioButton.UseVisualStyleBackColor = true;
			this.lettersAndNumbersRadioButton.CheckedChanged += new System.EventHandler(this.lettersAndNumbersRadioButton_CheckedChanged);
			// 
			// keyWordRadioButton
			// 
			this.keyWordRadioButton.AutoSize = true;
			this.keyWordRadioButton.Location = new System.Drawing.Point(6, 81);
			this.keyWordRadioButton.Name = "keyWordRadioButton";
			this.keyWordRadioButton.Size = new System.Drawing.Size(116, 19);
			this.keyWordRadioButton.TabIndex = 8;
			this.keyWordRadioButton.TabStop = true;
			this.keyWordRadioButton.Text = "Кодовое слово";
			this.keyWordRadioButton.UseVisualStyleBackColor = true;
			this.keyWordRadioButton.CheckedChanged += new System.EventHandler(this.keyWordRadioButton_CheckedChanged);
			// 
			// countOfSymbolsTextBox
			// 
			this.countOfSymbolsTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.countOfSymbolsTextBox.Location = new System.Drawing.Point(376, 211);
			this.countOfSymbolsTextBox.Name = "countOfSymbolsTextBox";
			this.countOfSymbolsTextBox.Size = new System.Drawing.Size(31, 23);
			this.countOfSymbolsTextBox.TabIndex = 9;
			this.countOfSymbolsTextBox.Click += new System.EventHandler(this.countOfSymbolsTextBox_Click);
			this.countOfSymbolsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countOfSymbolsTextBox_KeyPress);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordTextBox.Location = new System.Drawing.Point(307, 247);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(160, 23);
			this.passwordTextBox.TabIndex = 10;
			// 
			// countOfSymbolsLabel
			// 
			this.countOfSymbolsLabel.AutoSize = true;
			this.countOfSymbolsLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.countOfSymbolsLabel.Location = new System.Drawing.Point(248, 211);
			this.countOfSymbolsLabel.Name = "countOfSymbolsLabel";
			this.countOfSymbolsLabel.Size = new System.Drawing.Size(119, 15);
			this.countOfSymbolsLabel.TabIndex = 11;
			this.countOfSymbolsLabel.Text = "Кол-во символов:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordLabel.Location = new System.Drawing.Point(248, 247);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(56, 15);
			this.passwordLabel.TabIndex = 12;
			this.passwordLabel.Text = "Пароль:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numbersOnlyRadioButton);
			this.groupBox1.Controls.Add(this.lettersOnlyRadioButton);
			this.groupBox1.Controls.Add(this.lettersAndNumbersRadioButton);
			this.groupBox1.Controls.Add(this.keyWordRadioButton);
			this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(41, 85);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 107);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.russianRadioButton);
			this.groupBox2.Controls.Add(this.englishRadioButton);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(396, 85);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 60);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			// 
			// russianRadioButton
			// 
			this.russianRadioButton.AutoSize = true;
			this.russianRadioButton.Location = new System.Drawing.Point(6, 35);
			this.russianRadioButton.Name = "russianRadioButton";
			this.russianRadioButton.Size = new System.Drawing.Size(116, 19);
			this.russianRadioButton.TabIndex = 4;
			this.russianRadioButton.TabStop = true;
			this.russianRadioButton.Text = "Русские буквы";
			this.russianRadioButton.UseVisualStyleBackColor = true;
			this.russianRadioButton.CheckedChanged += new System.EventHandler(this.russianRadioButton_CheckedChanged);
			// 
			// englishRadioButton
			// 
			this.englishRadioButton.AutoSize = true;
			this.englishRadioButton.Location = new System.Drawing.Point(6, 12);
			this.englishRadioButton.Name = "englishRadioButton";
			this.englishRadioButton.Size = new System.Drawing.Size(137, 19);
			this.englishRadioButton.TabIndex = 3;
			this.englishRadioButton.TabStop = true;
			this.englishRadioButton.Text = "Английские буквы";
			this.englishRadioButton.UseVisualStyleBackColor = true;
			this.englishRadioButton.CheckedChanged += new System.EventHandler(this.englishRadioButton_CheckedChanged);
			// 
			// keyWordTextBox
			// 
			this.keyWordTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.keyWordTextBox.Location = new System.Drawing.Point(47, 198);
			this.keyWordTextBox.Name = "keyWordTextBox";
			this.keyWordTextBox.Size = new System.Drawing.Size(100, 23);
			this.keyWordTextBox.TabIndex = 15;
			// 
			// exitButton
			// 
			this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
			this.exitButton.Location = new System.Drawing.Point(605, 0);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(26, 26);
			this.exitButton.TabIndex = 16;
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// collapseButton
			// 
			this.collapseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.collapseButton.Image = ((System.Drawing.Image)(resources.GetObject("collapseButton.Image")));
			this.collapseButton.Location = new System.Drawing.Point(577, 0);
			this.collapseButton.Name = "collapseButton";
			this.collapseButton.Size = new System.Drawing.Size(26, 26);
			this.collapseButton.TabIndex = 17;
			this.collapseButton.UseVisualStyleBackColor = true;
			this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(634, 24);
			this.menuStrip.TabIndex = 18;
			this.menuStrip.Text = "menuStrip1";
			this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.подключитьКодовыеСловаToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("файлToolStripMenuItem.Image")));
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// подключитьКодовыеСловаToolStripMenuItem
			// 
			this.подключитьКодовыеСловаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("подключитьКодовыеСловаToolStripMenuItem.Image")));
			this.подключитьКодовыеСловаToolStripMenuItem.Name = "подключитьКодовыеСловаToolStripMenuItem";
			this.подключитьКодовыеСловаToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.подключитьКодовыеСловаToolStripMenuItem.Text = "Подключить кодовые слова";
			this.подключитьКодовыеСловаToolStripMenuItem.Click += new System.EventHandler(this.подключитьКодовыеСловаToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			// 
			// getRandomKeyWord
			// 
			this.getRandomKeyWord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.getRandomKeyWord.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.getRandomKeyWord.Location = new System.Drawing.Point(41, 224);
			this.getRandomKeyWord.Name = "getRandomKeyWord";
			this.getRandomKeyWord.Size = new System.Drawing.Size(155, 45);
			this.getRandomKeyWord.TabIndex = 19;
			this.getRandomKeyWord.Text = "Подобрать кодовое слово";
			this.getRandomKeyWord.UseVisualStyleBackColor = true;
			this.getRandomKeyWord.Click += new System.EventHandler(this.getRandomKeyWord_Click);
			// 
			// copyButton
			// 
			this.copyButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.copyButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.copyButton.Location = new System.Drawing.Point(473, 247);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(101, 26);
			this.copyButton.TabIndex = 20;
			this.copyButton.Text = "Скопировать";
			this.copyButton.UseVisualStyleBackColor = true;
			this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(38, 282);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 15);
			this.label1.TabIndex = 22;
			this.label1.Text = "Кол-во кодовых слов:";
			// 
			// countOfKeyWords
			// 
			this.countOfKeyWords.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.countOfKeyWords.Location = new System.Drawing.Point(191, 282);
			this.countOfKeyWords.Name = "countOfKeyWords";
			this.countOfKeyWords.Size = new System.Drawing.Size(31, 23);
			this.countOfKeyWords.TabIndex = 21;
			this.countOfKeyWords.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countOfKeyWords_KeyPress);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 361);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.countOfKeyWords);
			this.Controls.Add(this.copyButton);
			this.Controls.Add(this.getRandomKeyWord);
			this.Controls.Add(this.collapseButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.keyWordTextBox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.countOfSymbolsLabel);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.countOfSymbolsTextBox);
			this.Controls.Add(this.numbersInTheEndCheckBox);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.getPasswordButton);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainWindow";
			this.Text = "Pass-nerator";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button getPasswordButton;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.CheckBox numbersInTheEndCheckBox;
		private System.Windows.Forms.RadioButton lettersOnlyRadioButton;
		private System.Windows.Forms.RadioButton numbersOnlyRadioButton;
		private System.Windows.Forms.RadioButton lettersAndNumbersRadioButton;
		private System.Windows.Forms.RadioButton keyWordRadioButton;
		private System.Windows.Forms.TextBox countOfSymbolsTextBox;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label countOfSymbolsLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton russianRadioButton;
		private System.Windows.Forms.RadioButton englishRadioButton;
		private System.Windows.Forms.TextBox keyWordTextBox;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button collapseButton;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem подключитьКодовыеСловаToolStripMenuItem;
		private System.Windows.Forms.Button getRandomKeyWord;
		private System.Windows.Forms.Button copyButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox countOfKeyWords;
	}
}

