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
        }

        private void newRecordToolboxButton_Click(object sender, EventArgs e)
        {
            Form newRecordForm = new RecordForm();
            newRecordForm.Text = "Добавление записи";
            newRecordForm.ShowDialog(this);
        }

        private void newClientToolboxButton_Click(object sender, EventArgs e)
        {
            Form newClientForm = new ClientForm();
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
    }
}
