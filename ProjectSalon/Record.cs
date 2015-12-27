using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    [Serializable]
    public class Record
    {
        public Boolean status;
        public Service service;
        public Master master;
        public Client client;
        public DateTime day;
        public int hour;
        public int id;

        public Record(Service service, Master master, Client client, DateTime day, int hour)
        {            
            this.service = service;
            this.master = master;
            this.client = client;
            status = false;
            this.day = day;
            this.hour = hour;
        }

        override public String ToString()
        {
            return client.name + " - " + service.name + " (" + day.Day + "." + day.Month + "." + day.Year + " " + hour + ":00)";
        }

        /// <summary>
        /// Изменяет данные объекта класса Запись
        /// </summary>
        /// <param name="date">Дата исполнения услуги</param>
        /// <param name="service">Исполняемая услуга</param>
        /// <param name="master">Мастер, исполняющий услугу</param>
        /// <param name="client">Клиент, использующий услугу</param>
        public void change(Service service, Master master, Client client, DateTime day, int hour)
        {
            this.service = service;
            this.master = master;
            this.client = client;
            this.day = day;
            this.hour = hour;
        }

        /// <summary>
        /// Изменяет статус записи
        /// </summary>
        public void changeStatus()
        {
            status = !status;
        }
    }
}
