namespace ProjectSalon
{
    partial class SalonStatisticsForm
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
            this.monthCalendarReport = new System.Windows.Forms.MonthCalendar();
            this.labelCalendarTitle = new System.Windows.Forms.Label();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendarReport
            // 
            this.monthCalendarReport.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendarReport.Location = new System.Drawing.Point(33, 55);
            this.monthCalendarReport.MaxSelectionCount = 365;
            this.monthCalendarReport.Name = "monthCalendarReport";
            this.monthCalendarReport.TabIndex = 0;
            // 
            // labelCalendarTitle
            // 
            this.labelCalendarTitle.AutoSize = true;
            this.labelCalendarTitle.Location = new System.Drawing.Point(30, 19);
            this.labelCalendarTitle.Name = "labelCalendarTitle";
            this.labelCalendarTitle.Size = new System.Drawing.Size(234, 13);
            this.labelCalendarTitle.TabIndex = 1;
            this.labelCalendarTitle.Text = "Выберите временной диапазон (макс. 1 год)";
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(227, 229);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(138, 23);
            this.buttonCreateReport.TabIndex = 2;
            this.buttonCreateReport.Text = "Сформировать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // SalonStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 269);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.labelCalendarTitle);
            this.Controls.Add(this.monthCalendarReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalonStatisticsForm";
            this.ShowIcon = false;
            this.Text = "Формирование статистики салона";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarReport;
        private System.Windows.Forms.Label labelCalendarTitle;
        private System.Windows.Forms.Button buttonCreateReport;
    }
}