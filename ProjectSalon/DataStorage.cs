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

        public static DataStorage get()
        {
            if (sDataStorage == null)
                sDataStorage = new DataStorage();
            return sDataStorage;
        }

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

        public Service newService(String name, int price, int duration)
        {
            int id;
            if (serviceList.Count != 0) id = serviceID + (this.serviceList.Count() - 1);
            else id = serviceID;
            Service service = new Service(name, price, duration, id);
            this.serviceList.Add(service);
            return service;
        }

        public Client newClient(String name, String birth, String number)
        {
            Client client = new Client(name, birth, number);
            this.clientList.Add(client);
            return client;
        }

        public Salon newSalon(String address, String name)
        {
            this.salon = new Salon(address, name, salonDefaultID);
            return this.salon;
        }

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

        public List<Service> getServices()
        {
            return serviceList;
        }

        public List<Master> getMasters()
        {
            return masterList;
        }

        public List<Client> getClients()
        {
            return clientList;
        }

        public Salon getSalon()
        {
            return salon;
        }

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
