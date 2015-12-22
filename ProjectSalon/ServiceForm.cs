using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSalon
{
    public partial class ServiceForm : Form
    {
        Controller mainController;
        public ServiceForm(Controller controller)
        {
            InitializeComponent();
            this.mainController = controller;
            textBoxServiceDuration.Visible = false;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            String name = textBoxServiceName.Text;
            int price = Convert.ToInt32(textBoxServicePrice.Text);
            //int duration = Convert.ToInt32(textBoxServiceDuration.Text);
            int duration = trackBarDuration.Value;
            mainController.registerService(name, price, duration);
            this.Close();
        }

        private void trackBarDuration_Scroll(object sender, EventArgs e)
        {
            labelDuration.Text = Convert.ToString(trackBarDuration.Value);
        }
    }
}
