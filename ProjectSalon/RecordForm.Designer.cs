namespace ProjectSalon
{
    partial class RecordForm
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
            this.clientNameTitleRecord = new System.Windows.Forms.Label();
            this.clientNumberTitleRecord = new System.Windows.Forms.Label();
            this.masterNameTitleRecord = new System.Windows.Forms.Label();
            this.serviceNameTitleRecord = new System.Windows.Forms.Label();
            this.dateTitleRecord = new System.Windows.Forms.Label();
            this.mainMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientNumber = new System.Windows.Forms.TextBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFindClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientNameTitleRecord
            // 
            this.clientNameTitleRecord.AutoSize = true;
            this.clientNameTitleRecord.Location = new System.Drawing.Point(30, 70);
            this.clientNameTitleRecord.Name = "clientNameTitleRecord";
            this.clientNameTitleRecord.Size = new System.Drawing.Size(43, 13);
            this.clientNameTitleRecord.TabIndex = 1;
            this.clientNameTitleRecord.Text = "Клиент";
            // 
            // clientNumberTitleRecord
            // 
            this.clientNumberTitleRecord.AutoSize = true;
            this.clientNumberTitleRecord.Location = new System.Drawing.Point(30, 30);
            this.clientNumberTitleRecord.Name = "clientNumberTitleRecord";
            this.clientNumberTitleRecord.Size = new System.Drawing.Size(85, 13);
            this.clientNumberTitleRecord.TabIndex = 5;
            this.clientNumberTitleRecord.Text = "Номер клиента";
            // 
            // masterNameTitleRecord
            // 
            this.masterNameTitleRecord.AutoSize = true;
            this.masterNameTitleRecord.Location = new System.Drawing.Point(30, 150);
            this.masterNameTitleRecord.Name = "masterNameTitleRecord";
            this.masterNameTitleRecord.Size = new System.Drawing.Size(45, 13);
            this.masterNameTitleRecord.TabIndex = 6;
            this.masterNameTitleRecord.Text = "Мастер";
            // 
            // serviceNameTitleRecord
            // 
            this.serviceNameTitleRecord.AutoSize = true;
            this.serviceNameTitleRecord.Location = new System.Drawing.Point(30, 110);
            this.serviceNameTitleRecord.Name = "serviceNameTitleRecord";
            this.serviceNameTitleRecord.Size = new System.Drawing.Size(43, 13);
            this.serviceNameTitleRecord.TabIndex = 7;
            this.serviceNameTitleRecord.Text = "Услуга";
            // 
            // dateTitleRecord
            // 
            this.dateTitleRecord.AutoSize = true;
            this.dateTitleRecord.Location = new System.Drawing.Point(30, 190);
            this.dateTitleRecord.Name = "dateTitleRecord";
            this.dateTitleRecord.Size = new System.Drawing.Size(33, 13);
            this.dateTitleRecord.TabIndex = 8;
            this.dateTitleRecord.Text = "Дата";
            // 
            // mainMonthCalendar
            // 
            this.mainMonthCalendar.Enabled = false;
            this.mainMonthCalendar.Location = new System.Drawing.Point(242, 190);
            this.mainMonthCalendar.Name = "mainMonthCalendar";
            this.mainMonthCalendar.TabIndex = 9;
            this.mainMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mainMonthCalendar_DateChanged);
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(149, 147);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(257, 21);
            this.comboBoxMaster.TabIndex = 10;
            this.comboBoxMaster.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaster_SelectedIndexChanged);
            // 
            // comboBoxService
            // 
            this.comboBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(149, 107);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(257, 21);
            this.comboBoxService.TabIndex = 11;
            this.comboBoxService.SelectedIndexChanged += new System.EventHandler(this.comboBoxService_SelectedIndexChanged);
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(149, 67);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(257, 20);
            this.textBoxClientName.TabIndex = 12;
            // 
            // textBoxClientNumber
            // 
            this.textBoxClientNumber.Location = new System.Drawing.Point(149, 27);
            this.textBoxClientNumber.Name = "textBoxClientNumber";
            this.textBoxClientNumber.Size = new System.Drawing.Size(183, 20);
            this.textBoxClientNumber.TabIndex = 13;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.Enabled = false;
            this.comboBoxTime.Location = new System.Drawing.Point(149, 190);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(81, 21);
            this.comboBoxTime.TabIndex = 14;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(296, 364);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(110, 25);
            this.buttonApply.TabIndex = 15;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(168, 364);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 25);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFindClient
            // 
            this.buttonFindClient.Location = new System.Drawing.Point(338, 27);
            this.buttonFindClient.Name = "buttonFindClient";
            this.buttonFindClient.Size = new System.Drawing.Size(68, 20);
            this.buttonFindClient.TabIndex = 17;
            this.buttonFindClient.Text = "поиск";
            this.buttonFindClient.UseVisualStyleBackColor = true;
            this.buttonFindClient.Click += new System.EventHandler(this.buttonFindClient_Click);
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.buttonFindClient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.textBoxClientNumber);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.mainMonthCalendar);
            this.Controls.Add(this.dateTitleRecord);
            this.Controls.Add(this.serviceNameTitleRecord);
            this.Controls.Add(this.masterNameTitleRecord);
            this.Controls.Add(this.clientNumberTitleRecord);
            this.Controls.Add(this.clientNameTitleRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Добавление/изменение записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientNameTitleRecord;
        private System.Windows.Forms.Label clientNumberTitleRecord;
        private System.Windows.Forms.Label masterNameTitleRecord;
        private System.Windows.Forms.Label serviceNameTitleRecord;
        private System.Windows.Forms.Label dateTitleRecord;
        private System.Windows.Forms.MonthCalendar mainMonthCalendar;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientNumber;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFindClient;
    }
}