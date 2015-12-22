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
        List<String> serviceNames;
        Controller mainController;
        public MasterForm(MainForm mainForm)
        {
            InitializeComponent();
            serviceNames = new List<String>();
            this.mainController = mainForm.mainController;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            this.Close();
            string name = textBoxName.Text;
            int salary = Convert.ToInt32(textBoxSalary.Text);
            //XXX: Возможно, нужно сделать проверку размера serviceList перед созданием с предупреждением пользователя
            mainController.registerMaster(name, salary, serviceNames);
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            string serviceName = textBoxServiceName.Text;
            Service tmpService = mainController.getService(serviceName);

            if (tmpService != null)
            {
                serviceNames.Add(serviceName);
                listBoxService.Items.Add(serviceName);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Еще нет ни одного мастера, оказывающего данную услугу, добавить новую?", "Новая услуга", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ServiceForm newServiceForm = new ServiceForm();
                    newServiceForm.ShowDialog();
                }
                else if (dialogResult == DialogResult.No)
                {
                    textBoxServiceName.Text = "";
                }
            }
        }
    }
}
