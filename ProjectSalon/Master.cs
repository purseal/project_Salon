﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    [Serializable]
    public class Master
    {
        public String name;
        public int salary;
        public int id;
        Salon[] employerList = new Salon[3];
        public List<Service> serviceList;
        List<Record> recordList;

        DataStorage mainDataStorage;

        public Master(String name, int salary, int id)
        {
            this.name = name;
            this.salary = salary;
            this.id = id;
            this.serviceList = new List<Service>();
            this.recordList = new List<Record>();
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

        /// <summary>
        /// Добавляет салон в список салонов мастера
        /// </summary>
        /// <param name="salon">Салон, который будет добавлен</param>
        public void addSalon(Salon salon)
        {
            for (int i=0; i<=employerList.Length; i++)
            {
                if (employerList[i] != null)
                {
                    employerList[i] = salon;
                    return;
                }
            }
        }

        /// <summary>
        /// Возвращает список часов, свободных для записи
        /// </summary>
        /// <param name="day">Дата, для которой ищутся свободные часы</param>
        public List<int> getFreeHours(DateTime day)
        {
            mainDataStorage = DataStorage.get();
            List<int> fullHours = new List<int>();
            List<int> freeHours = new List<int>();
            foreach (Record record in recordList)
            {
                if (record.day == day)
                {
                    fullHours.Add(record.hour);
                }
            }
            for (int hour = mainDataStorage.getSalon().openHour; hour <= mainDataStorage.getSalon().closeHour; hour++)
            {
                if (!fullHours.Contains(hour))
                    freeHours.Add(hour);
            }
            return freeHours;
        }

        /// <summary>
        /// Изменяет данные объекта класса Мастер
        /// </summary>
        /// <param name="name">ФИО мастера</param>
        /// <param name="salary">Зарплата мастера</param>
        public void change(String name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        override public String ToString()
        {
            return name;
        }
    }
}
