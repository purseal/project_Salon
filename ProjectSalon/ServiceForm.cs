using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProjectSalon
{
    public partial class ServiceForm : Form
    {
        Controller mainController;
        bool edit;
        public ServiceForm(Controller controller, bool edit)
        {
            InitializeComponent();
            this.mainController = controller;
            textBoxServiceDuration.Visible = false;
            this.edit = edit;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                String name = textBoxServiceName.Text;
                int price = Convert.ToInt32(textBoxServicePrice.Text);
                //int duration = Convert.ToInt32(textBoxServiceDuration.Text);
                int duration = trackBarDuration.Value;
                mainController.changeService(name, price, duration, mainController.getService(name));
                this.Close();
            }
            else
            {
                String name = textBoxServiceName.Text;
                int price = Convert.ToInt32(textBoxServicePrice.Text);
                //int duration = Convert.ToInt32(textBoxServiceDuration.Text);
                int duration = trackBarDuration.Value;
                mainController.registerService(name, price, duration);
                this.Close();
            }
            
        }

        private void trackBarDuration_Scroll(object sender, EventArgs e)
        {
            labelDuration.Text = Convert.ToString(trackBarDuration.Value);
        }
    }
}
