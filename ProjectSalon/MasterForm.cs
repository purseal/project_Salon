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
    public partial class MasterForm : Form
    {
        List<Service> serviceList = new List<Service>();

        public MasterForm()
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int salary = Convert.ToInt32(textBoxSalary.Text);
            string name = textBoxName.Text;


=======
>>>>>>> origin/master
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            string serviceName = textBoxServiceName.Text;
            //TODO: Передать на контроллер имя, найти услугу
            bool serviceExists = false;
            Service serviceObject = null;
            if (serviceExists)
            {
                listBoxService.Items.Add(serviceObject); //XXX: На самом деле тут надо как-то вбить имя услуги
                service
            }
            else
            {

            }
        }
=======
>>>>>>> origin/master
    }
}
