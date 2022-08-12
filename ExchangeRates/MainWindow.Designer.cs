namespace ExchangeRates
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
			this.label1 = new System.Windows.Forms.Label();
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.startParse = new System.Windows.Forms.Button();
			this.codeLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.currencyLabel = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.countLabel = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.informationLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.exitButton = new System.Windows.Forms.Button();
			this.collapseButton = new System.Windows.Forms.Button();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вызодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.rateComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.statusStrip.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(59, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Название валюты:";
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fullNameLabel.Location = new System.Drawing.Point(194, 82);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(0, 16);
			this.fullNameLabel.TabIndex = 3;
			// 
			// startParse
			// 
			this.startParse.BackColor = System.Drawing.SystemColors.Control;
			this.startParse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.startParse.FlatAppearance.BorderSize = 0;
			this.startParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startParse.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startParse.Image = ((System.Drawing.Image)(resources.GetObject("startParse.Image")));
			this.startParse.Location = new System.Drawing.Point(189, 252);
			this.startParse.Name = "startParse";
			this.startParse.Size = new System.Drawing.Size(106, 54);
			this.startParse.TabIndex = 4;
			this.startParse.Text = "Получить данные";
			this.startParse.UseVisualStyleBackColor = false;
			this.startParse.Click += new System.EventHandler(this.startParse_Click);
			// 
			// codeLabel
			// 
			this.codeLabel.AutoSize = true;
			this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.codeLabel.Location = new System.Drawing.Point(193, 115);
			this.codeLabel.Name = "codeLabel";
			this.codeLabel.Size = new System.Drawing.Size(0, 16);
			this.codeLabel.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(59, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Цифровой код:";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameLabel.Location = new System.Drawing.Point(193, 156);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(0, 16);
			this.nameLabel.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(59, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 16);
			this.label6.TabIndex = 7;
			this.label6.Text = "Буквенный код:";
			// 
			// currencyLabel
			// 
			this.currencyLabel.AutoSize = true;
			this.currencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.currencyLabel.Location = new System.Drawing.Point(193, 191);
			this.currencyLabel.Name = "currencyLabel";
			this.currencyLabel.Size = new System.Drawing.Size(0, 16);
			this.currencyLabel.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(59, 191);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 16);
			this.label8.TabIndex = 9;
			this.label8.Text = "Курс:";
			// 
			// countLabel
			// 
			this.countLabel.AutoSize = true;
			this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.countLabel.Location = new System.Drawing.Point(416, 191);
			this.countLabel.Name = "countLabel";
			this.countLabel.Size = new System.Drawing.Size(0, 16);
			this.countLabel.TabIndex = 12;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(257, 191);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(157, 16);
			this.label10.TabIndex = 11;
			this.label10.Text = "за количество единиц:";
			// 
			// statusStrip
			// 
			this.statusStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 339);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(484, 22);
			this.statusStrip.TabIndex = 13;
			this.statusStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.statusStrip_MouseDown);
			// 
			// informationLabel
			// 
			this.informationLabel.Name = "informationLabel";
			this.informationLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// exitButton
			// 
			this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
			this.exitButton.Location = new System.Drawing.Point(457, 1);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(26, 26);
			this.exitButton.TabIndex = 0;
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitbutton_Click);
			// 
			// collapseButton
			// 
			this.collapseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.collapseButton.Image = ((System.Drawing.Image)(resources.GetObject("collapseButton.Image")));
			this.collapseButton.Location = new System.Drawing.Point(430, 1);
			this.collapseButton.Name = "collapseButton";
			this.collapseButton.Size = new System.Drawing.Size(26, 26);
			this.collapseButton.TabIndex = 15;
			this.collapseButton.UseVisualStyleBackColor = true;
			this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.sourceComboBox,
            this.rateComboBox});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(484, 27);
			this.menuStrip.TabIndex = 15;
			this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.вызодToolStripMenuItem});
			this.файлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("файлToolStripMenuItem.Image")));
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// вызодToolStripMenuItem
			// 
			this.вызодToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вызодToolStripMenuItem.Image")));
			this.вызодToolStripMenuItem.Name = "вызодToolStripMenuItem";
			this.вызодToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.вызодToolStripMenuItem.Text = "Выход";
			this.вызодToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
			// 
			// sourceComboBox
			// 
			this.sourceComboBox.BackColor = System.Drawing.Color.White;
			this.sourceComboBox.Name = "sourceComboBox";
			this.sourceComboBox.Size = new System.Drawing.Size(121, 23);
			this.sourceComboBox.SelectedIndexChanged += new System.EventHandler(this.sourceComboBox_SelectedIndexChanged);
			// 
			// rateComboBox
			// 
			this.rateComboBox.BackColor = System.Drawing.Color.White;
			this.rateComboBox.Name = "rateComboBox";
			this.rateComboBox.Size = new System.Drawing.Size(121, 23);
			this.rateComboBox.SelectedIndexChanged += new System.EventHandler(this.rateComboBox_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(12, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(460, 213);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.collapseButton);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.countLabel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.currencyLabel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.codeLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.startParse);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainWindow";
			this.Text = "Курсы валют";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Button startParse;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel informationLabel;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вызодToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox sourceComboBox;
        private System.Windows.Forms.ToolStripComboBox rateComboBox;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

