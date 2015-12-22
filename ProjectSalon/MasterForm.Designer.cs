namespace ProjectSalon
{
    partial class MasterForm
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
            this.masterNameTitle = new System.Windows.Forms.Label();
            this.masterSalaryTitle = new System.Windows.Forms.Label();
            this.masterServicesTitle = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // masterNameTitle
            // 
            this.masterNameTitle.AutoSize = true;
            this.masterNameTitle.Location = new System.Drawing.Point(30, 45);
            this.masterNameTitle.Name = "masterNameTitle";
            this.masterNameTitle.Size = new System.Drawing.Size(80, 13);
            this.masterNameTitle.TabIndex = 0;
            this.masterNameTitle.Text = "ФИО мастера";
            // 
            // masterSalaryTitle
            // 
            this.masterSalaryTitle.AutoSize = true;
            this.masterSalaryTitle.Location = new System.Drawing.Point(30, 115);
            this.masterSalaryTitle.Name = "masterSalaryTitle";
            this.masterSalaryTitle.Size = new System.Drawing.Size(55, 13);
            this.masterSalaryTitle.TabIndex = 1;
            this.masterSalaryTitle.Text = "Зарплата";
            // 
            // masterServicesTitle
            // 
            this.masterServicesTitle.AutoSize = true;
            this.masterServicesTitle.Location = new System.Drawing.Point(30, 194);
            this.masterServicesTitle.Name = "masterServicesTitle";
            this.masterServicesTitle.Size = new System.Drawing.Size(74, 13);
            this.masterServicesTitle.TabIndex = 2;
            this.masterServicesTitle.Text = "Список услуг";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(172, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(216, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(256, 112);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(132, 20);
            this.textBoxSalary.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(160, 290);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 25);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(300, 290);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(110, 25);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // listBoxService
            // 
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.Location = new System.Drawing.Point(172, 228);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(216, 56);
            this.listBoxService.TabIndex = 8;
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(362, 191);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(26, 20);
            this.buttonAddService.TabIndex = 9;
            this.buttonAddService.Text = "+";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(172, 191);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(184, 20);
            this.textBoxServiceName.TabIndex = 10;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 326);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.listBoxService);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.masterServicesTitle);
            this.Controls.Add(this.masterSalaryTitle);
            this.Controls.Add(this.masterNameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MasterForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Добавление/изменение мастера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label masterNameTitle;
        private System.Windows.Forms.Label masterSalaryTitle;
        private System.Windows.Forms.Label masterServicesTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ListBox listBoxService;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.TextBox textBoxServiceName;
    }
}