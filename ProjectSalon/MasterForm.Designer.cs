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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.masterServicesTitle.Location = new System.Drawing.Point(30, 185);
            this.masterServicesTitle.Name = "masterServicesTitle";
            this.masterServicesTitle.Size = new System.Drawing.Size(74, 13);
            this.masterServicesTitle.TabIndex = 2;
            this.masterServicesTitle.Text = "Список услуг";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(256, 182);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(132, 64);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Применить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 317);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}