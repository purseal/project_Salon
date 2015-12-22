using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    public class Service
    {
        public String name;
        public int price;
        public int duration;
        public int id;
        List<Record> recordList;
        List<Master> masterList;

        public Service(String name, int price, int duration, int id)
        {
            this.name = name;
            this.price = price;
            this.duration = duration;
            this.id = id;
        }

        public void addMaster(Master master)
        {
            masterList.Add(master);
        }

        public void addRecord(Record record)
        {
            recordList.Add(record);
        }

        override public String ToString()
        {
            return name;
        }
    }
}
