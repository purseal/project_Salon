using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectSalon
{
    [Serializable]
    public class Client
    {
        public String name;
        public String birth;
        public String number;
        List<Record> recordList;

        public Client(String name, String birth, String number)
        {
            this.name = name;
            this.birth = birth;
            this.number = number;
            this.recordList = new List<Record>();
        }

        /// <summary>
        /// Присоединяет запись к клиенту
        /// </summary>
        /// <param name="recordToLink">запись, которая будет присоединена</param>
        public void linkRecord(Record recordToLink)
        {
            this.recordList.Add(recordToLink);
        }

        override public String ToString()
        {
            return name;
        }

        /// <summary>
        /// Изменяет данные объекта класса Клиент
        /// </summary>
        /// <param name="name">ФИО клиента</param>
        /// <param name="birth">Дата рождения клиента</param>
        /// <param name="number">Телефонный номер клиента</param>
        public void change(String name, String birth, String number)
        {
            this.name = name;
            this.birth = birth;
            this.number = number;
        }

        /// <summary>
        /// Формирует статистику по клиенту 
        /// </summary>
        /// <returns>Статистика в текстовом виде</returns>
        public String getStatistic()
        {
            Dictionary<String, int> serviceDict = new Dictionary<string, int>();
            Dictionary<String, int> masterDict = new Dictionary<string, int>();
            int spendMoney = 0;
            foreach (Record record in recordList)
            {
                spendMoney += record.service.price;
                if (serviceDict.ContainsKey(record.service.name))
                {
                    serviceDict[record.service.name]++;
                }
                else
                {
                    serviceDict.Add(record.service.name, 0);
                }

                if (masterDict.ContainsKey(record.master.name))
                {
                    masterDict[record.master.name]++;
                }
                else
                {
                    masterDict.Add(record.master.name, 0);
                }

            }
            String clientStatistic = "Деньги, потраченные в салоне: " + spendMoney + " руб\n";
            return clientStatistic;
        }

    }
}
