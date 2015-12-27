using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectSalon
{
    [Serializable]
    class DataStorage
    {
        private static DataStorage sDataStorage;
        private List<Service> serviceList;
        private List<Master> masterList;
        private List<Client> clientList;
        private Salon salon;
        private readonly int masterID = 100;
        private readonly int serviceID = 200;
        private readonly int salonDefaultID = 1;

        /// <summary>
        /// Возвращает ссылку на DataStorage
        /// </summary>
        /// <returns></returns>
        public static DataStorage get()
        {
            if (sDataStorage == null)
                sDataStorage = new DataStorage();
            return sDataStorage;
        }

        /// <summary>
        /// Заменяет информацию текущего DataStorage информацией data
        /// </summary>
        /// <param name="data">Новая информация для DataStorage</param>
        public static void set(DataStorage data)
        {
            sDataStorage.salon = data.salon;
            sDataStorage.serviceList = data.serviceList;
            sDataStorage.masterList = data.masterList;
            sDataStorage.clientList = data.clientList;
        }

        private DataStorage()
        {
            this.clientList = new List<Client>();
            this.masterList = new List<Master>();
            this.serviceList = new List<Service>();
        }

        /// <summary>
        /// Инициализирует создание объекта класса Master
        /// </summary>
        /// <returns>Созданный мастер</returns>
        public Master newMaster(String name, int salary)
        {
            Debug.WriteLine("Создание мастера на DataStorage, размер masterList " + masterList.Count);

            int id;
            if (masterList.Count != 0)
                id = masterID + (this.masterList.Count() - 1);
            else id = masterID;
            Master master = new Master(name, salary, id);
            this.masterList.Add(master);
            Debug.WriteLine("Мастер добавлен в лист, размер листа " + masterList.Count);
            return master;
        }

        /// <summary>
        /// Инициализирует создание объекта класса Service
        /// </summary>
        /// <returns>Созданная услуга</returns>
        public Service newService(String name, int price, int duration)
        {
            int id;
            if (serviceList.Count != 0) id = serviceID + (this.serviceList.Count() - 1);
            else id = serviceID;
            Service service = new Service(name, price, duration, id);
            this.serviceList.Add(service);
            return service;
        }

        /// <summary>
        /// Инициализирует создание объекта класса Client
        /// </summary>
        /// <returns>Созданный клиент</returns>
        public Client newClient(String name, String birth, String number)
        {
            Client client = new Client(name, birth, number);
            this.clientList.Add(client);
            return client;
        }

        /// <summary>
        /// Инициализирует создание объекта класса Salon
        /// </summary>
        /// <returns>Созданный салон</returns>
        public Salon newSalon(String address, String name)
        {
            this.salon = new Salon(address, name, salonDefaultID);
            return this.salon;
        }

        /// <summary>
        /// Проводит удаление временных или более не нужных записей, хранящихся в DataStorage
        /// </summary>
        public void cleanTrashObject()
        {
            List<Client> clientToRemove = new List<Client>();
            List<Service> serviceToRemove = new List<Service>();
            foreach (Service service in serviceList)
            {
                if (service.masterList.Count == 0 & service.recordList.Count == 0)
                    serviceToRemove.Add(service);
            }

            foreach (Client client in clientList)
            {
                if (client.recordList.Count == 0)
                    clientToRemove.Add(client);
            }

            foreach (Client client in clientToRemove)
            {
                clientList.Remove(client);
            }

            foreach (Service service in serviceToRemove)
            {
                serviceList.Remove(service);
            }
            
        }

        /// <summary>
        /// Возвращает список услуг, хранящихся в DataStorage
        /// </summary>
        public List<Service> getServices()
        {
            return serviceList;
        }

        /// <summary>
        /// Возвращает список мастеров, хранящихся в DataStorage
        /// </summary>
        public List<Master> getMasters()
        {
            return masterList;
        }

        /// <summary>
        /// Возвращает список клиентов, хранящихся в DataStorage
        /// </summary>
        public List<Client> getClients()
        {
            return clientList;
        }

        /// <summary>
        /// Возвращает салон, хранящийся в DataStorage
        /// </summary>
        public Salon getSalon()
        {
            return salon;
        }

        /// <summary>
        /// Возвращает конкретного мастера по его id
        /// </summary>
        public Master getMaster(int id)
        {
            foreach (Master master in masterList)
            {
                if (master.id.Equals(id))
                {
                    return master;
                }
            }
            return null;
        }

        /// <summary>
        /// Возвращает конкретного клиента по его номеру
        /// </summary>
        public Client getClient(int number)
        {
            foreach (Client client in clientList)
            {
                if (client.number.Equals(number))
                {
                    return client;
                }
            }
            return null;
        }

        /// <summary>
        /// Возвращает конкретную услугу по её id
        /// </summary>
        public Service getService(int id)
        {
            foreach (Service service in serviceList)
            {
                if (service.id.Equals(id))
                {
                    return service;
                }
            }
            return null;
        }
    }
}
