using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectSalon
{
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

    }
}
