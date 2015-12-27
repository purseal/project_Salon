using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    [Serializable]
    public class Service
    {
        public String name;
        public int price;
        public int duration;
        public int id;
        public List<Record> recordList;
        public List<Master> masterList;

        public Service(String name, int price, int duration, int id)
        {
            this.name = name;
            this.price = price;
            this.duration = duration;
            this.id = id;
            this.recordList = new List<Record>();
            this.masterList = new List<Master>();
        }

        /// <summary>
        /// Добавляет мастера, оказывающего услугу
        /// </summary>
        public void addMaster(Master master)
        {
            masterList.Add(master);
        }

        /// <summary>
        /// Добавляет запись, в которой указана услуга
        /// </summary>
        public void linkRecord(Record record)
        {
            recordList.Add(record);
        }

        /// <summary>
        /// Изменяет данные объекта класса Клиент
        /// </summary>
        /// <param name="name">Название услуги</param>
        /// <param name="price">Стоимость услуги</param>
        /// <param name="duration">Продолжительность услуги</param>
        public void change(String name, int price, int duration)
        {
            this.name = name;
            this.price = price;
            this.duration = duration;
        }

        override public String ToString()
        {
            return name;
        }
    }
}
