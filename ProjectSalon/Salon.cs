using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    [Serializable]
    public class Salon
    {
        DataStorage mainDataStorage;
        public String address;
        public String name;
        int id;
        List<Master> masterList;
        List<Record> recordList;

        public Salon(String address, String name, int id)
        {
            this.address = address;
            this.id = id;
            this.name = name;
            this.masterList = new List<Master>();
            this.recordList = new List<Record>();
            mainDataStorage = DataStorage.get();
        }

        /// <summary>
        /// Создание записи в салоне
        /// </summary>
        /// <param name="date">дата записи</param>
        /// <param name="service">выбранная клиентом услуга</param>
        /// <param name="master">мастер</param>
        /// <param name="client">клиент</param>
        public Record addRecord(Service service, Master master, Client client, DateTime day, int hour)
        {
            Record newRecord = new Record(service, master, client, day, hour);
            recordList.Add(newRecord);
            service.linkRecord(newRecord);
            master.linkRecord(newRecord);
            client.linkRecord(newRecord);
            return newRecord;
        }

        /// <summary>
        /// Создание мастера в салоне
        /// </summary>
        /// <param name="master">мастер, работающий в салоне</param>
        public void addMaster(Master master)
        {
            masterList.Add(master);
        }

        /// <summary>
        /// Проверка зарегистрирован ли уже этот пользователь в салоне
        /// </summary>
        /// <param name="number">номер записываемого на прием клиента</param>
        public bool checkClientRegistration(String number)
        {
            foreach (Client client in mainDataStorage.getClients())
                if (client.number == number)
                    return true;

            return false;
        }

        /// <summary>
        /// Поиск по списку записей в салоне
        /// </summary>
        /// <param name="text">текст из поля, по которому производится поиск</param>
        public List<Record> getRecordList(String text)
        {
            if (text == "")
                return recordList;
            List<Record> result = new List<Record>();
            foreach (Record record in recordList)
            {
                if ((record.id.ToString().Contains(text)) || (record.client.name.ToLower().Contains(text.ToString())) || (record.master.name.ToLower().Contains(text.ToLower())) || (record.service.name.ToLower().Contains(text.ToLower())))
                    result.Add(record);
            }
            return result;
        }

        /// <summary>
        /// Поиск по списку услуг в салоне
        /// </summary>
        /// <param name="text">текст из поля, по которому производится поиск</param>
        public List<Service> getServiceList(String text)
        {
            if (text == "")
                return mainDataStorage.getServices();
            List<Service> result = new List<Service>();
            foreach (Service service in mainDataStorage.getServices())
            {
                if (service.name.ToLower().Contains(text.ToLower())) result.Add(service);
            }
            return result;
        }

        /// <summary>
        /// Поиск по списку мастеров в салоне
        /// </summary>
        /// <param name="text">текст из поля, по которому производится поиск</param>
        public List<Master> getMasterList(String text)
        {
            if (text == "")
                return mainDataStorage.getMasters();
            List<Master> result = new List<Master>();
            foreach (Master master in mainDataStorage.getMasters())
            {
                if ((master.name.ToLower().Contains(text.ToLower())) || (master.id.ToString().Contains(text))) result.Add(master);
            }
            return result;
        }

        /// <summary>
        /// Поиск по списку клиентов в салоне
        /// </summary>
        /// <param name="text">текст из поля, по которому производится поиск</param>
        public List<Client> getClientList(String text)
        {
            if (text == "")
                return mainDataStorage.getClients();
            List<Client> result = new List<Client>();
            foreach (Client client in mainDataStorage.getClients())
            {
                if ((client.name.ToLower().Contains(text.ToLower())) || (client.number.Contains(text))) result.Add(client);
            }
            return result;
        }

        override public String ToString()
        {
            return name;
        }
    }
}
