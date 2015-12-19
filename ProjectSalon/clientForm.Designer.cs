namespace ProjectSalon
{
    partial class ClientForm
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
            this.clientNameTitle = new System.Windows.Forms.Label();
            this.clientNumberTitle = new System.Windows.Forms.Label();
            this.birthDayTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientNameTitle
            // 
            this.clientNameTitle.AutoSize = true;
            this.clientNameTitle.Location = new System.Drawing.Point(30, 45);
            this.clientNameTitle.Name = "clientNameTitle";
            this.clientNameTitle.Size = new System.Drawing.Size(84, 13);
            this.clientNameTitle.TabIndex = 1;
            this.clientNameTitle.Text = "ФИО клиента: ";
            // 
            // clientNumberTitle
            // 
            this.clientNumberTitle.AutoSize = true;
            this.clientNumberTitle.Location = new System.Drawing.Point(30, 115);
            this.clientNumberTitle.Name = "clientNumberTitle";
            this.clientNumberTitle.Size = new System.Drawing.Size(96, 13);
            this.clientNumberTitle.TabIndex = 2;
            this.clientNumberTitle.Text = "Номер телефона:";
            // 
            // birthDayTitle
            // 
            this.birthDayTitle.AutoSize = true;
            this.birthDayTitle.Location = new System.Drawing.Point(30, 185);
            this.birthDayTitle.Name = "birthDayTitle";
            this.birthDayTitle.Size = new System.Drawing.Size(89, 13);
            this.birthDayTitle.TabIndex = 3;
            this.birthDayTitle.Text = "Дата рождения:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(256, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 6;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(302, 246);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(110, 25);
            this.buttonApply.TabIndex = 7;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(159, 246);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 25);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 296);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.birthDayTitle);
            this.Controls.Add(this.clientNumberTitle);
            this.Controls.Add(this.clientNameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Добавление/изменение клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientNameTitle;
        private System.Windows.Forms.Label clientNumberTitle;
        private System.Windows.Forms.Label birthDayTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}