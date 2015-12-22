using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    class DataStorage
    {
        private static DataStorage sDataStorage;
        private List<Service> serviceList;
        private List<Master> masterList;
        private List<Client> clientList;
        private Salon salon;
        private readonly int masterID = 100;
        private readonly int serviceID = 200;

        public static DataStorage get()
        {
            if (sDataStorage == null)
                sDataStorage = new DataStorage();
            return sDataStorage;
        }

        private DataStorage()
        {
            this.clientList = new List<Client>();
            this.masterList = new List<Master>();
            this.serviceList = new List<Service>();
        }

        public Master newMaster(String name, int salary)
        {
            int id;
            if (masterList.Count != 0) id = masterID + (this.masterList.Count() - 1);
            else id = masterID;
            Master master = new Master(name, salary, id);
            this.masterList.Add(master);
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

        public Client newClient(String name, DateTime birth)
        {
            Client client = new Client(name, birth);
            this.clientList.Add(client);
            return client;
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
