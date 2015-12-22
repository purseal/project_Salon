using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    public class Controller
    {
        DataStorage mainDataStorage;

        public Controller()
        {
            this.mainDataStorage = DataStorage.get();
        }
        /// <summary>
        /// Проводит создание и начальную подготовку объекта класса Master
        /// </summary>
        /// <param name="targetMaster">экземпляр объекта, сгенерированный в интерфейсе</param>
        public void registerMaster(string name, int salary, List<String> serviceNames)
        {
            List<Service> finalServiceList = new List<Service>();
            foreach (String serviceName in serviceNames)
            {
                Service targetService = getService(serviceName);
                if (targetService == null)
                {
                    //Такого быть не должно
                }
                else
                    finalServiceList.Add(targetService);
            }
            Master master = mainDataStorage.newMaster(name, salary);

            foreach (Service finalService in finalServiceList)
            {
                master.addService(finalService);
            }
        }

        /// <summary>
        /// Проводит создание и начальную подготовку объекта класса Record
        /// </summary>
        /// <param name="targetRecord">экземпляр объекта, сгенерированный в интерфейсе</param>
        public void registerRecord(Record targetRecord)
        {

        }

        /// <summary>
        /// Выводит список клиентов салона 
        /// </summary>
        /// <param name="request">запрос для поиска, если request==null, возвращает полный список</param>
        /// <returns>Список клиентов, содержащих в своих полях подстроку request</returns>
        public List<Client> getClientList(string request)
        {
            Salon salon = mainDataStorage.getSalon();

            return salon.getClientList(request);
        }

        /// <summary>
        /// Выводит список мастеров салона 
        /// </summary>
        /// <param name="request">запрос для поиска, если request==null, возвращает полный список</param>
        /// <returns>Список мастеров, содержащих в своих полях подстроку request</returns>
        public List<Master> getMasterList(string request)
        {
            Salon salon = mainDataStorage.getSalon();

            return salon.getMasterList(request);
        }

        /// <summary>
        /// Выводит список записей салона 
        /// </summary>
        /// <param name="request">запрос для поиска, если request==null, возвращает полный список</param>
        /// <returns>Список записей, содержащих в своих полях подстроку request</returns>
        public List<Record> getRecordList(string request)
        {
            Salon salon = mainDataStorage.getSalon();

            return salon.getRecordList(request);
        }

        /// <summary>
        /// Выводит список услуг салона 
        /// </summary>
        /// <param name="request">запрос для поиска, если request==null, возвращает полный список</param>
        /// <returns>Список услуг, содержащих в своих полях подстроку request</returns>
        public List<Service> getServiceList(string request)
        {
            Salon salon = mainDataStorage.getSalon();
            
            return salon.getServiceList(request);
        }

        public Service getService(string name)
        {
            List<Service> tmpServiceList = getServiceList(name);
            foreach (Service tmpService in tmpServiceList)
            {
                if (tmpService.name == name)
                {
                    return tmpService;
                }
            }
            return null;
        }
    }
}
