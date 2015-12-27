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
            mainController.registerSalon("Каширское шоссе, 11", "Красотка");
            this.Text = "Управление салоном \"" + mainDataStorage.getSalon().name + "\" (" + mainDataStorage.getSalon().address + ")";
            showPanel(0);
        }

        public void showPanel(int panelNum)
        {
            mainPanelClient.Visible = (panelNum == 1);
            mainPanelRecord.Visible = (panelNum == 2);
            mainPanelMaster.Visible = (panelNum == 3);
            mainPanelService.Visible = (panelNum == 4);
        }

        private void newRecordToolboxButton_Click(object sender, EventArgs e)
        {
            Form newRecordForm = new RecordForm(mainController, false, null);
            newRecordForm.Text = "Добавление записи";
            newRecordForm.ShowDialog(this);
            textBoxRecordSearch.Text = "";
            textBoxClientSearch.Text = "";
            textBoxRecordSearch_TextChanged(sender, e);
            textBoxClientSearch_TextChanged(sender, e);
            statusStripLabel.Text = "Добавление записи завершено";
        }

        private void newClientToolboxButton_Click(object sender, EventArgs e)
        {
            Form newClientForm = new ClientForm(mainController, false);
            newClientForm.Text = "Добавление клиента";
            newClientForm.ShowDialog(this);
        }

        private void newMasterToolboxButton_Click(object sender, EventArgs e)
        {
            Form newMasterForm = new MasterForm(this, false, null);
            newMasterForm.Text = "Добавление мастера";
            newMasterForm.ShowDialog(this);
            textBoxMasterSearch.Text = "";
            textBoxServiceSearch.Text = "";
            textBoxMasterSearch_TextChanged(sender, e);            
            textBoxServiceSearch_TextChanged(sender, e);
            statusStripLabel.Text = "Добавление мастера завершено";
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
            showPanel(1);
            if (clientListBox.SelectedItem == null)
                return;
            Client client = (Client)clientListBox.SelectedItem;
            clientNameLabel.Text = client.name;
            clientNumberLabel.Text = client.number;
            clientBirthDayLabel.Text = client.birth;
            richTextBoxStatistic.Text = client.getStatistic();
        }

        private void recordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPanel(2);
            if (recordListBox.SelectedItem == null)
                return;
            Record record = (Record)recordListBox.SelectedItem;
            if (!record.status && DateTime.Today < record.day)
                buttonRecordCompleted.Visible = true;
            else
                buttonRecordCompleted.Visible = false;
            labelRecordClientName.Text = record.client.name;
            labelRecordClientNumber.Text = record.client.number;
            labelRecordMasterName.Text = record.master.name;
            labelRecordServiceName.Text = record.service.name;
            labelRecordDate.Text = record.day.Day + "." + record.day.Month + "." + record.day.Year + " " + record.hour + ":00";
            if (record.status)
            {
                statusLabel.Text = "Выполнена";
            }
            else
            {
                if (DateTime.Today < record.day)
                    statusLabel.Text = "Ожидает выполнения";
                else
                    statusLabel.Text = "Клиент не пришел к назначенному времени";
            }
        }

        private void masterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            showPanel(3);
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
            showPanel(4);
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

        private void SaveBinaryFormat(object objGraph, string fileName)
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
                    Console.WriteLine("Не удалось провести сериализацию, причина - " + e.Message);
                    throw;
                }
                finally
                {
                    fStream.Close();
                }
            }
            Debug.WriteLine("--> Сохранение объекта в Binary format");
            statusStripLabel.Text = "Сохранение успешно выполнено";
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
                statusStripLabel.Text = "Загрузка информации для салона " + "\"" + mainDataStorage.getSalon().name + "\" успешно завершена";
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

        private void updateAllListBox(object sender, EventArgs e)
        {
            textBoxMasterSearch.Text = "";
            textBoxServiceSearch.Text = "";
            textBoxRecordSearch.Text = "";
            textBoxClientSearch.Text = "";
            textBoxMasterSearch_TextChanged(sender, e);
            textBoxServiceSearch_TextChanged(sender, e);
            textBoxRecordSearch_TextChanged(sender, e);
            textBoxClientSearch_TextChanged(sender, e);
            masterListBox_SelectedIndexChanged(sender, e);
            serviceListBox_SelectedIndexChanged(sender, e);
            recordListBox_SelectedIndexChanged(sender, e);
            clientListBox_SelectedIndexChanged(sender, e);
            showPanel(0);
            statusStripLabel.Text = "Изменения применены";
        }
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            int selectedTab = mainTabControl.SelectedIndex;
            switch (selectedTab)
            {
                //clientTab
                case 0:
                    if (clientListBox.SelectedItem != null)
                    {
                        Client client = (Client)clientListBox.SelectedItem;
                        ClientForm editClientForm = new ClientForm(mainController, true);
                        editClientForm.Text = "Изменение клиента";
                        editClientForm.textBoxClientName.Text = client.name;
                        editClientForm.textBoxClientNumber.Text = client.number;
                        editClientForm.textBoxClientNumber.Enabled = false;
                        editClientForm.textBoxClientBirth.Text = client.birth;
                        editClientForm.ShowDialog();
                        updateAllListBox(sender, e);
                    }
                    break;

                //recordTab
                case 1:
                    if (recordListBox.SelectedItem != null)
                    {
                        Record record = (Record)recordListBox.SelectedItem;
                        if (!record.status && (DateTime.Today < record.day))
                        {
                            RecordForm editRecordForm = new RecordForm(mainController, true, record);
                            editRecordForm.Text = "Изменение записи";
                            editRecordForm.textBoxClientName.Text = record.client.name;
                            editRecordForm.textBoxClientNumber.Text = record.client.number;
                            editRecordForm.textBoxClientName.Enabled = false;
                            editRecordForm.textBoxClientNumber.Enabled = false;
                            editRecordForm.ShowDialog();
                            updateAllListBox(sender, e);
                        }
                        else
                        {
                            if (record.status)
                                MessageBox.Show("Нельзя редактировать выполненную запись", "Ошибка", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("Нельзя редактировать запись с истекшим сроком", "Ошибка", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    break;

                //masterTab
                case 2:
                    if (masterListBox.SelectedItem != null)
                    {
                        Master master = (Master)masterListBox.SelectedItem;
                        MasterForm editMasterForm = new MasterForm(this, true, master);
                        editMasterForm.Text = "Изменение мастера";
                        editMasterForm.textBoxName.Text = master.name;
                        editMasterForm.textBoxSalary.Text = master.salary.ToString();
                        foreach (Service service in master.serviceList)
                        {
                            editMasterForm.listBoxService.Items.Add(service);
                        }
                        editMasterForm.ShowDialog();
                        updateAllListBox(sender, e);
                    }

                    break;

                //serviceTab
                case 3:
                    if (serviceListBox.SelectedItem != null)
                    {
                        Service service = (Service)serviceListBox.SelectedItem;
                        ServiceForm editServiceForm = new ServiceForm(mainController, true);
                        editServiceForm.Text = "Изменение услуги";
                        editServiceForm.textBoxServiceName.Text = service.name;
                        editServiceForm.trackBarDuration.Value = service.duration;
                        editServiceForm.textBoxServicePrice.Text = service.price.ToString();
                        editServiceForm.ShowDialog();
                        updateAllListBox(sender, e);
                    }
                    break;

            }
        }

        private void buttonRecordCompleted_Click(object sender, EventArgs e)
        {
            Record record = (Record)recordListBox.SelectedItem;
            if (record != null)
            {
                mainController.changeRecordStatus(record);
                statusStripLabel.Text = "Изменен статус записи";
                recordListBox_SelectedIndexChanged(sender, e);
                buttonRecordCompleted.Visible = false;
            }
            
        }

        private void linkLabelStatistic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Client client = (Client)clientListBox.SelectedItem;
            if (client != null)
            {
                richTextBoxStatistic.Visible = !richTextBoxStatistic.Visible;
            }
            
        }
    }
}
