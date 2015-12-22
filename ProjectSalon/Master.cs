using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    public class Master
    {
        public String name;
        int salary;
        public int id;
        Salon[] employerList = new Salon[3];
        List<Service> serviceList;
        List<Record> recordList;

        public Master(String name, int salary, int id)
        {
            this.name = name;
            this.salary = salary;
            this.id = id;
        }

        /// <summary>
        /// Присоединяет запись к мастеру
        /// </summary>
        /// <param name="recordToLink">запись, которая будет присоединена</param>
        public void linkRecord(Record recordToLink)
        {
            this.recordList.Add(recordToLink);
        }

        /// <summary>
        /// Добавляет услугу, оказываемую мастером
        /// </summary>
        /// <param name="serviceToAdd">услуга, которую оказывает мастер</param>
        public void addService(Service serviceToAdd)
        {
            //XXX:делать клонирование объекта или передавать ссылку
            //на тот, который был создан в интерфейсе?
            this.serviceList.Add(serviceToAdd);
        } 


    }
}
