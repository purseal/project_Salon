using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace ProjectSalon
{
    public partial class SalonStatisticsForm : Form
    {
        public SalonStatisticsForm()
        {
            InitializeComponent();
        }

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            if (monthCalendarReport.SelectionStart != null && monthCalendarReport.SelectionEnd != null)
            {
                DataStorage dataStorage = DataStorage.get();
                List<String> salonReport;
                salonReport = dataStorage.getSalon().getStatistics(monthCalendarReport.SelectionStart, monthCalendarReport.SelectionEnd);
                try
                {                    
                    System.IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "salonStatistic.htm", salonReport);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ошибка сохранения отчета - " + exception.Message, "Ошибка сохранения", MessageBoxButtons.OK);
                }
                System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "salonStatistic.htm");
                this.Close();
            }
        }
    }
}
