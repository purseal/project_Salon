using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    public class Record
    {
        public DateTime date;
        public Boolean status;
        public Service service;
        public Master master;
        public Client client;
        public int id;

        public Record(DateTime date, Service service, Master master, Client client)
        {
            this.date = date;
            this.service = service;
            this.master = master;
            this.client = client;
            status = false;
        }
    }
}
