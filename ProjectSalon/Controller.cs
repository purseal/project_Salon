using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    class Controller
    {
        /// <summary>
        /// Проводит создание и начальную подготовку объекта класса Master
        /// </summary>
        /// <param name="targetMaster">экземпляр объекта, сгенерированный в интерфейсе</param>
        public void registerMaster(Master targetMaster)
        {

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
            return null;
        }

        /// <summary>
        /// Выводит список мастеров салона 
        /// </summary>
        /// <param name="request">запрос для поиска, если request==null, возвращает полный список</param>
        /// <returns>Список мастеров, содержащих в своих полях подстроку request</returns>
        public List<Master> getMasterList(string request)
        {
            return null;
        }

        /// <summary>
        /// Выводит список записей салона 
        /// </summary>
        /// <param name="request">запрос для поиска, если request==null, возвращает полный список</param>
        /// <returns>Список записей, содержащих в своих полях подстроку request</returns>
        public List<Record> getRecordList(string request)
        {
            return null;
        }

        /// <summary>
        /// Выводит список услуг салона 
        /// </summary>
        /// <param name="request">запрос для поиска, если request==null, возвращает полный список</param>
        /// <returns>Список услуг, содержащих в своих полях подстроку request</returns>
        public List<Service> getServiceList(string request)
        {
            return null;
        }
    }
}
