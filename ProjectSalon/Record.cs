using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    class Record
    {
        DateTime date;
        Boolean status;
        Service service;
        Master master;
        Client client;

        Record(DateTime date, Service service, Master master, Client client)
        {
            this.date = date;
            this.service = service;
            this.master = master;
            this.client = client;
            status = false;
        }
    }
}
