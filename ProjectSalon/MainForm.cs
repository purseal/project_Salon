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
    public partial class MainForm : Form
    {
        public Controller mainController;
        DataStorage mainDataStorage;
        public MainForm()
        {
            InitializeComponent();
            mainController = new Controller();
            mainDataStorage = DataStorage.get();
            mainController.registerSalon("Каширское шоссе, 11", "Красотка");
            this.Text = "Управление салоном \"" + mainDataStorage.getSalon().name + "\" (" + mainDataStorage.getSalon().address + ")";
            mainPanelClient.Visible = false;
            mainPanelRecord.Visible = false;
            mainPanelMaster.Visible = false;
            mainPanelService.Visible = false;
        }

        private void newRecordToolboxButton_Click(object sender, EventArgs e)
        {
            Form newRecordForm = new RecordForm(mainController);
            newRecordForm.Text = "Добавление записи";
            newRecordForm.ShowDialog(this);
            textBoxRecordSearch.Text = "";
            textBoxClientSearch.Text = "";
            textBoxRecordSearch_TextChanged(sender, e);
            textBoxClientSearch_TextChanged(sender, e);
        }

        private void newClientToolboxButton_Click(object sender, EventArgs e)
        {
            Form newClientForm = new ClientForm(mainController);
            newClientForm.Text = "Добавление клиента";
            newClientForm.ShowDialog(this);
        }

        private void newMasterToolboxButton_Click(object sender, EventArgs e)
        {
            Form newMasterForm = new MasterForm(this);
            newMasterForm.Text = "Добавление мастера";
            newMasterForm.ShowDialog(this);
            textBoxMasterSearch.Text = "";
            textBoxServiceSearch.Text = "";
            textBoxMasterSearch_TextChanged(sender, e);            
            textBoxServiceSearch_TextChanged(sender, e);
        }

        private void textBoxClientSearch_TextChanged(object sender, EventArgs e)
        {
            List<Client> clientList = mainController.getClientList(textBoxClientSearch.Text);
            clientListBox.Items.Clear();
            foreach (Client client in clientList)
            {
                clientListBox.Items.Add(client);
            }
        }

        private void textBoxRecordSearch_TextChanged(object sender, EventArgs e)
        {
            List<Record> recordList = mainController.getRecordList(textBoxRecordSearch.Text);
            recordListBox.Items.Clear();
            foreach (Record record in recordList)
            {
                recordListBox.Items.Add(record);
            }
        }

        private void textBoxMasterSearch_TextChanged(object sender, EventArgs e)
        {
            List<Master> masterList = mainController.getMasterList(textBoxMasterSearch.Text);
            masterListBox.Items.Clear();
            foreach (Master master in masterList)
            {
                masterListBox.Items.Add(master);
            }
        }

        private void textBoxServiceSearch_TextChanged(object sender, EventArgs e)
        {
            List<Service> serviceList = mainController.getServiceList(textBoxServiceSearch.Text);
            serviceListBox.Items.Clear();
            foreach (Service service in serviceList)
            {
                serviceListBox.Items.Add(service);
            }
        }

        private void clientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainPanelClient.Visible = true;
            mainPanelRecord.Visible = false;
            mainPanelMaster.Visible = false;
            mainPanelService.Visible = false;

            Client client = (Client)clientListBox.SelectedItem;
            clientNameLabel.Text = client.name;
            clientNumberLabel.Text = client.number;
            clientBirthDayLabel.Text = client.birth;
        }

        private void recordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainPanelClient.Visible = false;
            mainPanelRecord.Visible = true;
            mainPanelMaster.Visible = false;
            mainPanelService.Visible = false;
            Record record = (Record)recordListBox.SelectedItem;
            labelRecordClientName.Text = record.client.name;
            labelRecordClientNumber.Text = record.client.number;
            labelRecordMasterName.Text = record.master.name;
            labelRecordServiceName.Text = record.service.name;
            labelRecordDate.Text = record.day.Day + "." + record.day.Month + "." + record.day.Year + " " + record.hour + ":00";
        }

        private void masterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainPanelClient.Visible = false;
            mainPanelRecord.Visible = false;
            mainPanelMaster.Visible = true;
            mainPanelService.Visible = false;
            Master master = (Master)masterListBox.SelectedItem;
            labelMasterName.Text = master.name;
            labelMasterSalary.Text = Convert.ToString(master.salary);
            foreach (Service service in master.serviceList)
            {
                listBoxMasterServices.Items.Add(service);
            }            
        }

        private void serviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainPanelClient.Visible = false;
            mainPanelRecord.Visible = false;
            mainPanelMaster.Visible = false;
            mainPanelService.Visible = true;
            Service service = (Service)serviceListBox.SelectedItem;
            labelServiceDuration.Text = Convert.ToString(service.duration);
            labelServiceName.Text = service.name;
            labelServicePrice.Text = Convert.ToString(service.price);
        }
    }
}
