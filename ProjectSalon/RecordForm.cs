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
    public partial class RecordForm : Form
    {
        Controller mainController;
        Master currentMaster;
        List<int> freeHours;
        bool edit;
        Record inputRecord;
        public RecordForm(Controller controller, bool edit, Record record)
        {
            InitializeComponent();
            mainController = controller;

            List<Service> serviceList = mainController.getServiceList("");
            foreach (Service service in serviceList)
            {
                comboBoxService.Items.Add(service);
            }
            this.edit = edit;
            inputRecord = record;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                Service service = (Service)comboBoxService.SelectedItem;
                Master master = (Master)comboBoxMaster.SelectedItem;
                Client client = mainController.getClient(textBoxClientNumber.Text);
                DateTime day = mainMonthCalendar.SelectionStart;
                int hour = (int)comboBoxTime.SelectedItem;
                mainController.changeRecord(service, master, client, day, hour, true, inputRecord);
                this.Close();
            }
            else
            {
                Service service = (Service)comboBoxService.SelectedItem;
                Master master = (Master)comboBoxMaster.SelectedItem;
                Client client = mainController.getClient(textBoxClientNumber.Text);
                DateTime day = mainMonthCalendar.SelectionStart;
                int hour = (int)comboBoxTime.SelectedItem;
                mainController.registerRecord(service, master, client, day, hour);
                this.Close();
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFindClient_Click(object sender, EventArgs e)
        {
            String clientNumber = textBoxClientNumber.Text;
            Client client = mainController.getClient(clientNumber);


            if (client == null)
            {
                DialogResult dialogResult = MessageBox.Show("Еще нет клиента с таким номером.\nЗарегистрировать нового клиента?", "Новый клиент", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ClientForm newClientForm = new ClientForm(mainController, false);
                    newClientForm.textBoxClientNumber.Text = Convert.ToString(clientNumber);
                    newClientForm.textBoxClientNumber.Enabled = false;
                    newClientForm.ShowDialog();
                    client = mainController.getClient(clientNumber);
                    textBoxClientNumber.Enabled = false;
                    textBoxClientName.Text = client.name;
                    textBoxClientName.Enabled = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    textBoxClientNumber.Text = "";
                }
            }
            else
            {
                textBoxClientNumber.Enabled = false;
                textBoxClientName.Text = client.name;
                textBoxClientName.Enabled = false;
            }            
        }

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaster.Items.Clear();
            Service selectedService = (Service)comboBoxService.SelectedItem;
            List<Master> masterList = selectedService.masterList;
            Debug.WriteLine("Размер листа с мастерами услуги равен " + masterList.Count);
            foreach (Master master in masterList)
                comboBoxMaster.Items.Add(master);
        }

        private void mainMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime day = mainMonthCalendar.SelectionStart;
            if (currentMaster != null)
            {
                freeHours = currentMaster.getFreeHours(day);                
            }
            comboBoxTime.Enabled = true;
            comboBoxTime.Items.Clear();
            foreach (int hour in freeHours)
                comboBoxTime.Items.Add(hour);                
        }

        private void comboBoxMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            Master selectedMaster = (Master)comboBoxMaster.SelectedItem;
            mainMonthCalendar.Enabled = true;
            if (selectedMaster != null)
                currentMaster = selectedMaster;
        }
    }
}
