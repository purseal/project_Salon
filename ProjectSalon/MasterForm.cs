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
    public partial class MasterForm : Form
    {
        List<String> serviceNames;
        Controller mainController;
        bool edit;
        Master inputMaster;
        public MasterForm(MainForm mainForm, bool edit, Master master)
        {
            InitializeComponent();
            serviceNames = new List<String>();
            this.mainController = mainForm.mainController;
            this.edit = edit;
            inputMaster = master;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                string name = textBoxName.Text;
                int salary = Convert.ToInt32(textBoxSalary.Text);
                //XXX: Возможно, нужно сделать проверку размера serviceList перед созданием с предупреждением пользователя
                Debug.WriteLine("Вызов registerMaster из формы");
                mainController.changeMaster(name, salary, inputMaster);
                this.Close();
            }
            else
            {               
                string name = textBoxName.Text;
                int salary = Convert.ToInt32(textBoxSalary.Text);
                //XXX: Возможно, нужно сделать проверку размера serviceList перед созданием с предупреждением пользователя
                Debug.WriteLine("Вызов registerMaster из формы");
                mainController.registerMaster(name, salary, serviceNames);
                this.Close();
            }

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            string serviceName = textBoxServiceName.Text;
            if (serviceName == "")
            {
                MessageBox.Show("Необходимо ввести название услуги", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            Service tmpService = mainController.getService(serviceName);

            if (tmpService != null)
            {
                serviceNames.Add(serviceName);
                listBoxService.Items.Add(serviceName);
                textBoxServiceName.Text = "";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Еще нет ни одного мастера, оказывающего данную услугу.\nДобавить новую услугу?", "Новая услуга", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ServiceForm newServiceForm = new ServiceForm(mainController, false);
                    newServiceForm.textBoxServiceName.Text = serviceName;
                    newServiceForm.textBoxServiceName.Enabled = false;
                    newServiceForm.ShowDialog();
                    listBoxService.Items.Add(serviceName);
                    serviceNames.Add(serviceName);
                    textBoxServiceName.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    textBoxServiceName.Text = "";
                }                
            }
        }
    }
}
