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
        public DateTime birth;
        public int number;
        List<Record> recordList;

        public Client(String name, DateTime birth)
        {
            this.name = name;
            this.birth = birth;
        }

        /// <summary>
        /// Присоединяет запись к клиенту
        /// </summary>
        /// <param name="recordToLink">запись, которая будет присоединена</param>
        public void linkRecord(Record recordToLink)
        {
            this.recordList.Add(recordToLink);
        }


    }
}
