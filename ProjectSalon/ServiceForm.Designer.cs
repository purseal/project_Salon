namespace ProjectSalon
{
    partial class ServiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServicePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxServiceDuration = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarDuration = new System.Windows.Forms.TrackBar();
            this.labelDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(112, 26);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(204, 20);
            this.textBoxServiceName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость:";
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.Location = new System.Drawing.Point(112, 80);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Size = new System.Drawing.Size(204, 20);
            this.textBoxServicePrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Длительность:";
            // 
            // textBoxServiceDuration
            // 
            this.textBoxServiceDuration.Location = new System.Drawing.Point(25, 203);
            this.textBoxServiceDuration.Name = "textBoxServiceDuration";
            this.textBoxServiceDuration.Size = new System.Drawing.Size(126, 20);
            this.textBoxServiceDuration.TabIndex = 5;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(251, 203);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(84, 29);
            this.buttonApply.TabIndex = 10;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "мин";
            // 
            // trackBarDuration
            // 
            this.trackBarDuration.LargeChange = 10;
            this.trackBarDuration.Location = new System.Drawing.Point(112, 129);
            this.trackBarDuration.Maximum = 60;
            this.trackBarDuration.Minimum = 5;
            this.trackBarDuration.Name = "trackBarDuration";
            this.trackBarDuration.Size = new System.Drawing.Size(139, 45);
            this.trackBarDuration.SmallChange = 5;
            this.trackBarDuration.TabIndex = 12;
            this.trackBarDuration.TickFrequency = 5;
            this.trackBarDuration.Value = 5;
            this.trackBarDuration.Scroll += new System.EventHandler(this.trackBarDuration_Scroll);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(270, 129);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(13, 13);
            this.labelDuration.TabIndex = 13;
            this.labelDuration.Text = "5";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 244);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.trackBarDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxServiceDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxServicePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.label1);
            this.Name = "ServiceForm";
            this.Text = "Добавление услуги";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxServiceName;
        public System.Windows.Forms.TextBox textBoxServicePrice;
        public System.Windows.Forms.TextBox textBoxServiceDuration;
        public System.Windows.Forms.TrackBar trackBarDuration;
        private System.Windows.Forms.Label labelDuration;
    }
}