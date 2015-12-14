namespace ProjectSalon
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.добавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.mainPanelClient = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.mainPanelMaster = new System.Windows.Forms.Panel();
            this.mainPanelRecord = new System.Windows.Forms.Panel();
            this.mainPanelService = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.mainPanelMaster.SuspendLayout();
            this.mainPanelRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1016, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // добавлениеToolStripMenuItem
            // 
            this.добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            this.добавлениеToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.добавлениеToolStripMenuItem.Text = "Добавление";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 50);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ProjectSalon.Properties.Resources.addRecord;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(119, 47);
            this.toolStripButton1.Text = "Добавить запись";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::ProjectSalon.Properties.Resources.addClient;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(126, 47);
            this.toolStripButton2.Text = "Добавить клиента";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::ProjectSalon.Properties.Resources.addMaster;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(127, 47);
            this.toolStripButton3.Text = "Добавить мастера";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.tabControl1);
            this.leftPanel.Location = new System.Drawing.Point(0, 77);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(301, 471);
            this.leftPanel.TabIndex = 2;
            // 
            // mainPanelClient
            // 
            this.mainPanelClient.Location = new System.Drawing.Point(307, 77);
            this.mainPanelClient.Name = "mainPanelClient";
            this.mainPanelClient.Size = new System.Drawing.Size(445, 471);
            this.mainPanelClient.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(7, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(291, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(283, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(275, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запись";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(275, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Мастер";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(275, 465);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Услуга";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Фамилия, имя, отчество клиента, идентификатор...";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(5, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(5, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(263, 20);
            this.textBox4.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Островский Леонид Валерьевич",
            "Рыков Семен Олегович",
            "Зверев Май Антонович",
            "Кропанин Денис Яковлевич",
            "Мятлев Лазарь Германович",
            "Бурков Корнилий Ростиславович",
            "Дегтярев Фридрих Осипович",
            "Беломестнов Вольдемар Эммануилович",
            "Дёмин Алан Германович",
            "Кондуров Остап Владиславович",
            "Есипов Гордей Аркадьевич",
            "Якушин Эдгар Емельянович",
            "Савасин Елизар Рудольфович",
            "Сапожников Шерлок Львович",
            "Мисалов Сабир Дмитриевич",
            "Курепин Рафаил Аркадьевич",
            "Шелагин Володар Лазаревич",
            "Симакин Тимур Денисович",
            "Лешев Рафик Лазаревич",
            "Бобр Талик Михайлович",
            "Малинов Арий Юльевич",
            "Рожков Давид Августович",
            "Минин Матвей Кондратьевич",
            "Чудов Ашот Евгеньевич",
            "Васнецов Константин Илларионович",
            "Ряхин Джамал Арсеньевич",
            "Денисов Вячеслав Павлович",
            "Васнецов Камиль Дмитриевич",
            "Костомаров Рем Вениаминович",
            "Симакин Заур Артурович"});
            this.listBox1.Location = new System.Drawing.Point(6, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 379);
            this.listBox1.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Location = new System.Drawing.Point(758, 44);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(257, 517);
            this.rightPanel.TabIndex = 5;
            // 
            // mainPanelMaster
            // 
            this.mainPanelMaster.Controls.Add(this.mainPanelRecord);
            this.mainPanelMaster.Location = new System.Drawing.Point(304, 77);
            this.mainPanelMaster.Name = "mainPanelMaster";
            this.mainPanelMaster.Size = new System.Drawing.Size(445, 471);
            this.mainPanelMaster.TabIndex = 4;
            // 
            // mainPanelRecord
            // 
            this.mainPanelRecord.Controls.Add(this.mainPanelService);
            this.mainPanelRecord.Location = new System.Drawing.Point(0, 0);
            this.mainPanelRecord.Name = "mainPanelRecord";
            this.mainPanelRecord.Size = new System.Drawing.Size(445, 471);
            this.mainPanelRecord.TabIndex = 4;
            // 
            // mainPanelService
            // 
            this.mainPanelService.Location = new System.Drawing.Point(0, 0);
            this.mainPanelService.Name = "mainPanelService";
            this.mainPanelService.Size = new System.Drawing.Size(445, 471);
            this.mainPanelService.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 573);
            this.Controls.Add(this.mainPanelMaster);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainPanelClient);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.rightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Project Salon";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.mainPanelMaster.ResumeLayout(false);
            this.mainPanelRecord.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel mainPanelClient;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel mainPanelMaster;
        private System.Windows.Forms.Panel mainPanelRecord;
        private System.Windows.Forms.Panel mainPanelService;
    }
}

