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
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.TabPage = new System.Windows.Forms.TabPage();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.textBoxClientSearch = new System.Windows.Forms.TextBox();
            this.recordTabPage = new System.Windows.Forms.TabPage();
            this.textBoxRecordSearch = new System.Windows.Forms.TextBox();
            this.masterTabPage = new System.Windows.Forms.TabPage();
            this.textBoxMasterSearch = new System.Windows.Forms.TextBox();
            this.mainPanelClient = new System.Windows.Forms.Panel();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.serviceTabPage = new System.Windows.Forms.TabPage();
            this.recordListBox = new System.Windows.Forms.ListBox();
            this.masterListBox = new System.Windows.Forms.ListBox();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.clientNameTitle = new System.Windows.Forms.Label();
            this.clientNumberTitle = new System.Windows.Forms.Label();
            this.birthDayTitle = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientNumberLabel = new System.Windows.Forms.Label();
            this.clientBirthDayLabel = new System.Windows.Forms.Label();
            this.recordGridView = new System.Windows.Forms.DataGridView();
            this.recordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.master = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanelRecord = new System.Windows.Forms.Panel();
            this.newRecordToolboxButton = new System.Windows.Forms.ToolStripButton();
            this.newClientToolboxButton = new System.Windows.Forms.ToolStripButton();
            this.newMasterToolboxButton = new System.Windows.Forms.ToolStripButton();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clientNameTitleRecord = new System.Windows.Forms.Label();
            this.masterNameTitleRecord = new System.Windows.Forms.Label();
            this.serviceNameTitleRecord = new System.Windows.Forms.Label();
            this.dateTitleRecord = new System.Windows.Forms.Label();
            this.clientNumberTitleRecord = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.TabPage.SuspendLayout();
            this.recordTabPage.SuspendLayout();
            this.masterTabPage.SuspendLayout();
            this.mainPanelClient.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.serviceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordGridView)).BeginInit();
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
            this.mainMenuStrip.Size = new System.Drawing.Size(1116, 24);
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
            // mainToolStrip
            // 
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainToolStrip.GripMargin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRecordToolboxButton,
            this.newClientToolboxButton,
            this.newMasterToolboxButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1116, 50);
            this.mainToolStrip.Stretch = true;
            this.mainToolStrip.TabIndex = 1;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.mainTabControl);
            this.leftPanel.Location = new System.Drawing.Point(10, 80);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 470);
            this.leftPanel.TabIndex = 2;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.TabPage);
            this.mainTabControl.Controls.Add(this.recordTabPage);
            this.mainTabControl.Controls.Add(this.masterTabPage);
            this.mainTabControl.Controls.Add(this.serviceTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(5, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(290, 465);
            this.mainTabControl.TabIndex = 0;
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.clientListBox);
            this.TabPage.Controls.Add(this.textBoxClientSearch);
            this.TabPage.Location = new System.Drawing.Point(4, 22);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage.Size = new System.Drawing.Size(282, 439);
            this.TabPage.TabIndex = 0;
            this.TabPage.Text = "Клиент";
            this.TabPage.UseVisualStyleBackColor = true;
            // 
            // clientListBox
            // 
            this.clientListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.ItemHeight = 15;
            this.clientListBox.Location = new System.Drawing.Point(5, 40);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(270, 379);
            this.clientListBox.TabIndex = 1;
            // 
            // textBoxClientSearch
            // 
            this.textBoxClientSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxClientSearch.Location = new System.Drawing.Point(5, 5);
            this.textBoxClientSearch.Name = "textBoxClientSearch";
            this.textBoxClientSearch.Size = new System.Drawing.Size(270, 20);
            this.textBoxClientSearch.TabIndex = 0;
            this.textBoxClientSearch.Text = "Фамилия, имя, отчество клиента, идентификатор...";
            // 
            // recordTabPage
            // 
            this.recordTabPage.Controls.Add(this.recordListBox);
            this.recordTabPage.Controls.Add(this.textBoxRecordSearch);
            this.recordTabPage.Location = new System.Drawing.Point(4, 22);
            this.recordTabPage.Name = "recordTabPage";
            this.recordTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.recordTabPage.Size = new System.Drawing.Size(282, 439);
            this.recordTabPage.TabIndex = 1;
            this.recordTabPage.Text = "Запись";
            this.recordTabPage.UseVisualStyleBackColor = true;
            // 
            // textBoxRecordSearch
            // 
            this.textBoxRecordSearch.Location = new System.Drawing.Point(5, 5);
            this.textBoxRecordSearch.Name = "textBoxRecordSearch";
            this.textBoxRecordSearch.Size = new System.Drawing.Size(263, 20);
            this.textBoxRecordSearch.TabIndex = 1;
            // 
            // masterTabPage
            // 
            this.masterTabPage.Controls.Add(this.masterListBox);
            this.masterTabPage.Controls.Add(this.textBoxMasterSearch);
            this.masterTabPage.Location = new System.Drawing.Point(4, 22);
            this.masterTabPage.Name = "masterTabPage";
            this.masterTabPage.Size = new System.Drawing.Size(282, 439);
            this.masterTabPage.TabIndex = 2;
            this.masterTabPage.Text = "Мастер";
            this.masterTabPage.UseVisualStyleBackColor = true;
            // 
            // textBoxMasterSearch
            // 
            this.textBoxMasterSearch.Location = new System.Drawing.Point(5, 5);
            this.textBoxMasterSearch.Name = "textBoxMasterSearch";
            this.textBoxMasterSearch.Size = new System.Drawing.Size(263, 20);
            this.textBoxMasterSearch.TabIndex = 1;
            // 
            // mainPanelClient
            // 
            this.mainPanelClient.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanelClient.Controls.Add(this.recordGridView);
            this.mainPanelClient.Controls.Add(this.clientBirthDayLabel);
            this.mainPanelClient.Controls.Add(this.clientNumberLabel);
            this.mainPanelClient.Controls.Add(this.clientNameLabel);
            this.mainPanelClient.Controls.Add(this.birthDayTitle);
            this.mainPanelClient.Controls.Add(this.clientNumberTitle);
            this.mainPanelClient.Controls.Add(this.clientNameTitle);
            this.mainPanelClient.Location = new System.Drawing.Point(315, 80);
            this.mainPanelClient.Name = "mainPanelClient";
            this.mainPanelClient.Size = new System.Drawing.Size(465, 465);
            this.mainPanelClient.TabIndex = 3;
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 551);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(1116, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 4;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.Window;
            this.rightPanel.Location = new System.Drawing.Point(800, 80);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(286, 465);
            this.rightPanel.TabIndex = 5;
            // 
            // serviceTabPage
            // 
            this.serviceTabPage.Controls.Add(this.serviceListBox);
            this.serviceTabPage.Location = new System.Drawing.Point(4, 22);
            this.serviceTabPage.Name = "serviceTabPage";
            this.serviceTabPage.Size = new System.Drawing.Size(282, 439);
            this.serviceTabPage.TabIndex = 3;
            this.serviceTabPage.Text = "Услуга";
            this.serviceTabPage.UseVisualStyleBackColor = true;
            // 
            // recordListBox
            // 
            this.recordListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordListBox.FormattingEnabled = true;
            this.recordListBox.ItemHeight = 15;
            this.recordListBox.Location = new System.Drawing.Point(5, 40);
            this.recordListBox.Name = "recordListBox";
            this.recordListBox.Size = new System.Drawing.Size(270, 379);
            this.recordListBox.TabIndex = 2;
            // 
            // masterListBox
            // 
            this.masterListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterListBox.FormattingEnabled = true;
            this.masterListBox.ItemHeight = 15;
            this.masterListBox.Location = new System.Drawing.Point(5, 40);
            this.masterListBox.Name = "masterListBox";
            this.masterListBox.Size = new System.Drawing.Size(270, 379);
            this.masterListBox.TabIndex = 2;
            // 
            // serviceListBox
            // 
            this.serviceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 15;
            this.serviceListBox.Location = new System.Drawing.Point(5, 10);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(270, 409);
            this.serviceListBox.TabIndex = 2;
            // 
            // clientNameTitle
            // 
            this.clientNameTitle.AutoSize = true;
            this.clientNameTitle.Location = new System.Drawing.Point(40, 40);
            this.clientNameTitle.Name = "clientNameTitle";
            this.clientNameTitle.Size = new System.Drawing.Size(84, 13);
            this.clientNameTitle.TabIndex = 0;
            this.clientNameTitle.Text = "ФИО клиента: ";
            // 
            // clientNumberTitle
            // 
            this.clientNumberTitle.AutoSize = true;
            this.clientNumberTitle.Location = new System.Drawing.Point(40, 90);
            this.clientNumberTitle.Name = "clientNumberTitle";
            this.clientNumberTitle.Size = new System.Drawing.Size(96, 13);
            this.clientNumberTitle.TabIndex = 1;
            this.clientNumberTitle.Text = "Номер телефона:";
            // 
            // birthDayTitle
            // 
            this.birthDayTitle.AutoSize = true;
            this.birthDayTitle.Location = new System.Drawing.Point(40, 140);
            this.birthDayTitle.Name = "birthDayTitle";
            this.birthDayTitle.Size = new System.Drawing.Size(89, 13);
            this.birthDayTitle.TabIndex = 2;
            this.birthDayTitle.Text = "Дата рождения:";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(260, 40);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(131, 13);
            this.clientNameLabel.TabIndex = 3;
            this.clientNameLabel.Text = "Фамилия Имя Отчество";
            // 
            // clientNumberLabel
            // 
            this.clientNumberLabel.AutoSize = true;
            this.clientNumberLabel.Location = new System.Drawing.Point(260, 90);
            this.clientNumberLabel.Name = "clientNumberLabel";
            this.clientNumberLabel.Size = new System.Drawing.Size(82, 13);
            this.clientNumberLabel.TabIndex = 4;
            this.clientNumberLabel.Text = "(000) 000-00-00";
            // 
            // clientBirthDayLabel
            // 
            this.clientBirthDayLabel.AutoSize = true;
            this.clientBirthDayLabel.Location = new System.Drawing.Point(260, 140);
            this.clientBirthDayLabel.Name = "clientBirthDayLabel";
            this.clientBirthDayLabel.Size = new System.Drawing.Size(61, 13);
            this.clientBirthDayLabel.TabIndex = 5;
            this.clientBirthDayLabel.Text = "00.00.0000";
            // 
            // recordGridView
            // 
            this.recordGridView.AllowUserToAddRows = false;
            this.recordGridView.AllowUserToDeleteRows = false;
            this.recordGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.recordGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.recordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordId,
            this.date,
            this.service,
            this.master,
            this.status});
            this.recordGridView.Location = new System.Drawing.Point(20, 250);
            this.recordGridView.Name = "recordGridView";
            this.recordGridView.ReadOnly = true;
            this.recordGridView.RowHeadersVisible = false;
            this.recordGridView.Size = new System.Drawing.Size(430, 165);
            this.recordGridView.TabIndex = 6;
            // 
            // recordId
            // 
            this.recordId.Frozen = true;
            this.recordId.HeaderText = "№ Записи";
            this.recordId.Name = "recordId";
            this.recordId.ReadOnly = true;
            // 
            // date
            // 
            this.date.Frozen = true;
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 60;
            // 
            // service
            // 
            this.service.Frozen = true;
            this.service.HeaderText = "Услуга";
            this.service.Name = "service";
            this.service.ReadOnly = true;
            // 
            // master
            // 
            this.master.Frozen = true;
            this.master.HeaderText = "Мастер";
            this.master.Name = "master";
            this.master.ReadOnly = true;
            // 
            // status
            // 
            this.status.Frozen = true;
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // mainPanelRecord
            // 
            this.mainPanelRecord.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanelRecord.Controls.Add(this.label10);
            this.mainPanelRecord.Controls.Add(this.label9);
            this.mainPanelRecord.Controls.Add(this.label8);
            this.mainPanelRecord.Controls.Add(this.label7);
            this.mainPanelRecord.Controls.Add(this.label6);
            this.mainPanelRecord.Controls.Add(this.clientNumberTitleRecord);
            this.mainPanelRecord.Controls.Add(this.dateTitleRecord);
            this.mainPanelRecord.Controls.Add(this.serviceNameTitleRecord);
            this.mainPanelRecord.Controls.Add(this.masterNameTitleRecord);
            this.mainPanelRecord.Controls.Add(this.clientNameTitleRecord);
            this.mainPanelRecord.Location = new System.Drawing.Point(315, 80);
            this.mainPanelRecord.Name = "mainPanelRecord";
            this.mainPanelRecord.Size = new System.Drawing.Size(465, 465);
            this.mainPanelRecord.TabIndex = 6;
            // 
            // newRecordToolboxButton
            // 
            this.newRecordToolboxButton.Image = global::ProjectSalon.Properties.Resources.addRecord;
            this.newRecordToolboxButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newRecordToolboxButton.Name = "newRecordToolboxButton";
            this.newRecordToolboxButton.Size = new System.Drawing.Size(119, 47);
            this.newRecordToolboxButton.Text = "Добавить запись";
            this.newRecordToolboxButton.Click += new System.EventHandler(this.newRecordToolboxButton_Click);
            // 
            // newClientToolboxButton
            // 
            this.newClientToolboxButton.Image = global::ProjectSalon.Properties.Resources.addClient;
            this.newClientToolboxButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newClientToolboxButton.Name = "newClientToolboxButton";
            this.newClientToolboxButton.Size = new System.Drawing.Size(126, 47);
            this.newClientToolboxButton.Text = "Добавить клиента";
            this.newClientToolboxButton.Click += new System.EventHandler(this.newClientToolboxButton_Click);
            // 
            // newMasterToolboxButton
            // 
            this.newMasterToolboxButton.Image = global::ProjectSalon.Properties.Resources.addMaster;
            this.newMasterToolboxButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMasterToolboxButton.Name = "newMasterToolboxButton";
            this.newMasterToolboxButton.Size = new System.Drawing.Size(127, 47);
            this.newMasterToolboxButton.Text = "Добавить мастера";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(45, 17);
            this.statusStripLabel.Text = "Готово";
            // 
            // clientNameTitleRecord
            // 
            this.clientNameTitleRecord.AutoSize = true;
            this.clientNameTitleRecord.Location = new System.Drawing.Point(40, 40);
            this.clientNameTitleRecord.Name = "clientNameTitleRecord";
            this.clientNameTitleRecord.Size = new System.Drawing.Size(43, 13);
            this.clientNameTitleRecord.TabIndex = 0;
            this.clientNameTitleRecord.Text = "Клиент";
            // 
            // masterNameTitleRecord
            // 
            this.masterNameTitleRecord.AutoSize = true;
            this.masterNameTitleRecord.Location = new System.Drawing.Point(40, 140);
            this.masterNameTitleRecord.Name = "masterNameTitleRecord";
            this.masterNameTitleRecord.Size = new System.Drawing.Size(45, 13);
            this.masterNameTitleRecord.TabIndex = 1;
            this.masterNameTitleRecord.Text = "Мастер";
            // 
            // serviceNameTitleRecord
            // 
            this.serviceNameTitleRecord.AutoSize = true;
            this.serviceNameTitleRecord.Location = new System.Drawing.Point(40, 190);
            this.serviceNameTitleRecord.Name = "serviceNameTitleRecord";
            this.serviceNameTitleRecord.Size = new System.Drawing.Size(43, 13);
            this.serviceNameTitleRecord.TabIndex = 2;
            this.serviceNameTitleRecord.Text = "Услуга";
            // 
            // dateTitleRecord
            // 
            this.dateTitleRecord.AutoSize = true;
            this.dateTitleRecord.Location = new System.Drawing.Point(40, 240);
            this.dateTitleRecord.Name = "dateTitleRecord";
            this.dateTitleRecord.Size = new System.Drawing.Size(33, 13);
            this.dateTitleRecord.TabIndex = 3;
            this.dateTitleRecord.Text = "Дата";
            // 
            // clientNumberTitleRecord
            // 
            this.clientNumberTitleRecord.AutoSize = true;
            this.clientNumberTitleRecord.Location = new System.Drawing.Point(40, 90);
            this.clientNumberTitleRecord.Name = "clientNumberTitleRecord";
            this.clientNumberTitleRecord.Size = new System.Drawing.Size(85, 13);
            this.clientNumberTitleRecord.TabIndex = 4;
            this.clientNumberTitleRecord.Text = "Номер клиента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Фамилия Имя Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "00000000000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Фамилия Имя Отчество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Название услуги";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "00.00.0000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 573);
            this.Controls.Add(this.mainPanelRecord);
            this.Controls.Add(this.mainPanelClient);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Project Salon";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.TabPage.ResumeLayout(false);
            this.TabPage.PerformLayout();
            this.recordTabPage.ResumeLayout(false);
            this.recordTabPage.PerformLayout();
            this.masterTabPage.ResumeLayout(false);
            this.masterTabPage.PerformLayout();
            this.mainPanelClient.ResumeLayout(false);
            this.mainPanelClient.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.serviceTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordGridView)).EndInit();
            this.mainPanelRecord.ResumeLayout(false);
            this.mainPanelRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton newRecordToolboxButton;
        private System.Windows.Forms.ToolStripButton newClientToolboxButton;
        private System.Windows.Forms.ToolStripButton newMasterToolboxButton;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel mainPanelClient;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage TabPage;
        private System.Windows.Forms.TabPage recordTabPage;
        private System.Windows.Forms.TabPage masterTabPage;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.TextBox textBoxClientSearch;
        private System.Windows.Forms.TextBox textBoxRecordSearch;
        private System.Windows.Forms.TextBox textBoxMasterSearch;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.TabPage serviceTabPage;
        private System.Windows.Forms.ListBox recordListBox;
        private System.Windows.Forms.ListBox masterListBox;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.DataGridView recordGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn master;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label clientBirthDayLabel;
        private System.Windows.Forms.Label clientNumberLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label birthDayTitle;
        private System.Windows.Forms.Label clientNumberTitle;
        private System.Windows.Forms.Label clientNameTitle;
        private System.Windows.Forms.Panel mainPanelRecord;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label clientNumberTitleRecord;
        private System.Windows.Forms.Label dateTitleRecord;
        private System.Windows.Forms.Label serviceNameTitleRecord;
        private System.Windows.Forms.Label masterNameTitleRecord;
        private System.Windows.Forms.Label clientNameTitleRecord;
    }
}

