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
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            String name = textBoxServiceName.Text;
            int price = Convert.ToInt32(textBoxServicePrice.Text);
            int duration = Convert.ToInt32(textBoxServiceDuration.Text);
            mainController.registerService(name, price, duration);
            this.Close();
        }

    }
}
