using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSalon
{
    [Serializable]
    public class Salon
    {
        public const int DEFAUILT_OPEN_TIME = 10;
        public const int DEFAUILT_CLOSE_TIME = 20;
        DataStorage mainDataStorage;
        public String address;
        public String name;
        int id;
        List<Master> masterList;
        List<Record> recordList;
        public int openHour;
        public int closeHour;

        public Salon(String address, String name, int id)
        {
            this.address = address;
            this.id = id;
            this.name = name;
            this.masterList = new List<Master>();
            this.recordList = new List<Record>();
            mainDataStorage = DataStorage.get();
            openHour = DEFAUILT_OPEN_TIME;
            closeHour = DEFAUILT_CLOSE_TIME;
        }

        /// <summary>
        /// Создание записи в салоне
        /// </summary>
        /// <param name="date">дата записи</param>
        /// <param name="service">выбранная клиентом услуга</param>
        /// <param name="master">мастер</param>
        /// <param name="client">клиент</param>
        public Record addRecord(Service service, Master master, Client client, DateTime day, int hour)
        {
            Record newRecord = new Record(service, master, client, day, hour);
            recordList.Add(newRecord);
            service.linkRecord(newRecord);
            master.linkRecord(newRecord);
            client.linkRecord(newRecord);
            return newRecord;
        }

        /// <summary>
        /// Создание мастера в салоне
        /// </summary>
        /// <param name="master">мастер, работающий в салоне</param>
        public void addMaster(Master master)
        {
            masterList.Add(master);
        }

        /// <summary>
        /// Проверка зарегистрирован ли уже этот пользователь в салоне
        /// </summary>
        /// <param name="number">номер записываемого на прием клиента</param>
        public bool checkClientRegistration(String number)
        {
            foreach (Client client in mainDataStorage.getClients())
                if (client.number == number)
                    return true;

            return false;
        }

        /// <summary>
        /// Поиск по списку записей в салоне
        /// </summary>
        /// <param name="text">текст из поля, по которому производится поиск</param>
        public List<Record> getRecordList(String text)
        {
            if (text == "")
                return recordList;
            List<Record> result = new List<Record>();
            foreach (Record record in recordList)
            {
                if ((record.id.ToString().Contains(text)) || (record.client.name.ToLower().Contains(text.ToString())) || (record.master.name.ToLower().Contains(text.ToLower())) || (record.service.name.ToLower().Contains(text.ToLower())))
                    result.Add(record);
            }
            return result;
        }

        /// <summary>
        /// Поиск по списку услуг в салоне
        /// </summary>
        /// <param name="text">текст из поля, по которому производится поиск</param>
        public List<Service> getServiceList(String text)
        {
            if (text == "")
                return mainDataStorage.getServices();
            List<Service> result = new List<Service>();
            foreach (Service service in mainDataStorage.getServices())
            {
                if (service.name.ToLower().Contains(text.ToLower())) result.Add(service);
            }
            return result;
        }

        /// <summary>
        /// Поиск по списку мастеров в салоне
        /// </summary>
        /// <param name="text">текст из поля, по которому производится поиск</param>
        public List<Master> getMasterList(String text)
        {
            if (text == "")
                return mainDataStorage.getMasters();
            List<Master> result = new List<Master>();
            foreach (Master master in mainDataStorage.getMasters())
            {
                if ((master.name.ToLower().Contains(text.ToLower())) || (master.id.ToString().Contains(text))) result.Add(master);
            }
            return result;
        }

        /// <summary>
        /// Поиск по списку клиентов в салоне
        /// </summary>
        /// <param name="text">текст из поля, по которому производится поиск</param>
        public List<Client> getClientList(String text)
        {
            if (text == "")
                return mainDataStorage.getClients();
            List<Client> result = new List<Client>();
            foreach (Client client in mainDataStorage.getClients())
            {
                if ((client.name.ToLower().Contains(text.ToLower())) || (client.number.Contains(text))) result.Add(client);
            }
            return result;
        }

        /// <summary>
        /// Формирование статистики по салону
        /// </summary>
        /// <param name="from">левая временная граница анализа</param>
        /// <param name="to">правая временная граница анализа</param>
        public List<String> getStatistics(DateTime from, DateTime to)
        {
            int recordCount = 0;
            int salarySum = 0;
            int recordsSum = 0;
            int maxMast, maxServ;
            List<String> output = new List<string>();
            Dictionary<Service, int> popularService = new Dictionary<Service, int>();
            Dictionary<Master, int> popularMaster = new Dictionary<Master, int>();
            Dictionary<Master, int> masterMoney = new Dictionary<Master, int>();
            foreach (Master master in this.getMasterList(""))
            {
                if (!(popularMaster.ContainsKey(master)))
                {
                    popularMaster.Add(master, 0);
                    masterMoney.Add(master, 0);
                    salarySum += master.salary;
                }
            }

            foreach (Record record in this.getRecordList(""))
            {
                if ((from <= record.day) && (to >= record.day) && (record.status))
                {
                    recordCount++;
                    if (popularService.ContainsKey(record.service))
                        popularService[record.service]++;
                    else
                        popularService.Add(record.service, 0);

                    if (popularMaster.ContainsKey(record.master))
                        popularMaster[record.master]++;

                    if (masterMoney.ContainsKey(record.master))
                        masterMoney[record.master] += record.service.price;

                    recordsSum += record.service.price;
                }
            }

            if (recordCount < 1)
            {
                output.Add("<p> <b>СТАТИСТИКА ПО САЛОНУ \"" + name + "\" </b></p>");
                output.Add("Общее количество записей за выбранный период времени : " + recordCount + "<br />");
                output.Add("Общая сумма на зарплаты : " + salarySum + "<br />");
                output.Add("Общая сумма с оказанных услуг : " + recordsSum + "<br />");
                output.Add("Прибыль за выбранный период времени : " + (recordsSum - salarySum) + "<br />");
                output.Insert(0, "<HTML><meta charset=\"utf-8\"><BODY>");
                output.Add("</BODY></HTML>");
                return output;
            }
                

            maxMast = popularMaster.Values.Max();
            maxServ = popularService.Values.Max();

            String bestMasters = "", bestServices = "";
            for (int i = 0; i < popularMaster.Count; i++)
            {
                if (popularMaster.ElementAt(i).Value == maxMast)
                {
                    if (bestMasters == "")
                        bestMasters += popularMaster.ElementAt(i).Key.name;
                    else
                        bestMasters += ", " + popularMaster.ElementAt(i).Key.name;
                }
            }
            for (int i = 0; i < popularService.Count; i++)
            {
                if (popularService.ElementAt(i).Value == maxServ)
                {
                    if (bestServices == "")
                        bestServices += popularService.ElementAt(i).Key;
                    else
                        bestServices += ", " + popularService.ElementAt(i).Key;
                }
            }
            output.Add("<p> <b>СТАТИСТИКА ПО САЛОНУ \"" + name + "\" </b></p>");
            output.Add("Общее количество записей за выбранный период времени : " + recordCount + "<br />");
            output.Add("Наиболее популярный мастер : " + bestMasters + "<br />");
            output.Add("Наиболее популярная услуга : " + bestServices + "<br />");
            output.Add("Общая сумма на зарплаты : " + salarySum + "<br />");
            output.Add("Общая сумма с оказанных услуг : " + recordsSum + "<br />");
            output.Add("Прибыль за выбранный период времени : " + (recordsSum - salarySum) + "<br />");

            output.Add("<br /><b>СТАТИСТИКА ПО МАСТЕРАМ</b>" + "<br /><br />");
            for (int i = 0; i < masterMoney.Count; i++)
            {
                output.Add("<b>" + masterMoney.ElementAt(i).Key.name + "</b>" + "(Количество записей: " + popularMaster.ElementAt(i).Value + ")" + "<br />");
                output.Add("    -Зарплата : " + masterMoney.ElementAt(i).Key.salary + " рублей" + "<br />");
                output.Add("    -Сумма с оказанных услуг : " + masterMoney.ElementAt(i).Value + " рублей" + "<br />");
                output.Add("    -Прибыль : " + (masterMoney.ElementAt(i).Value - masterMoney.ElementAt(i).Key.salary) + " рублей" + "<br /><br />");
            }
            output.Insert(0, "<HTML><meta charset=\"utf-8\"><BODY>");
            output.Add("</BODY></HTML>");
            return output;            
        }

        override public String ToString()
        {
            return name;
        }
    }
}
