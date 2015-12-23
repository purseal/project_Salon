using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

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
            mainController.registerSalon("Рублевское шоссе, 69", "Красотка2");
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
            if (clientListBox.SelectedItem == null)
                return;
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
            if (recordListBox.SelectedItem == null)
                return;
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
            if (masterListBox.SelectedItem == null)
                return;
            Master master = (Master)masterListBox.SelectedItem;
            labelMasterName.Text = master.name;
            labelMasterSalary.Text = Convert.ToString(master.salary);
            listBoxMasterServices.Items.Clear();
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
            if (serviceListBox.SelectedItem == null)
                return;
            Service service = (Service)serviceListBox.SelectedItem;
            labelServiceDuration.Text = Convert.ToString(service.duration);
            labelServiceName.Text = service.name;
            labelServicePrice.Text = Convert.ToString(service.price);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveBinaryFormat(mainDataStorage, "dataStorage.dat");
        }

        static void SaveBinaryFormat(object objGraph, string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                try
                {
                    binFormat.Serialize(fStream, objGraph);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                    throw;
                }
                finally
                {
                    fStream.Close();
                }
            }
            Debug.WriteLine("--> Сохранение объекта в Binary format");
        }

        private void toolStripButtonLoad_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Запущена загрузка");
            DataStorage data;
            using (Stream fStream = File.OpenRead("dataStorage.dat"))
            {
                try
                {
                    BinaryFormatter binFormat = new BinaryFormatter();
                    data = (DataStorage)binFormat.Deserialize(fStream);
                    DataStorage.set(data);
                }
                catch (SerializationException ex)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + ex.Message);
                    throw;
                }
                finally
                {
                    fStream.Close();
                }
                Debug.WriteLine("Загрузка выполнена:");
                Debug.WriteLine("---загруженный салон в DS " + mainDataStorage.getSalon());
                Debug.WriteLine("---загруженный салон data " + data.getSalon());
            }
            textBoxMasterSearch.Text = "";
            textBoxServiceSearch.Text = "";
            textBoxRecordSearch.Text = "";
            textBoxClientSearch.Text = "";
            textBoxMasterSearch_TextChanged(sender, e);
            textBoxServiceSearch_TextChanged(sender, e);
            textBoxRecordSearch_TextChanged(sender, e);
            textBoxClientSearch_TextChanged(sender, e);
            this.Text = "Управление салоном \"" + mainDataStorage.getSalon().name + "\" (" + mainDataStorage.getSalon().address + ")";
        }
    }
}
