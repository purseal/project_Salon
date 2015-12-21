using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    class DataStorage
    {
        List<Record> recordList;
        List<Master> masterList;
        List<Client> clientList;
        Salon salon;

        public DataStorage(Salon targetSalon)
        {
            this.clientList = new List<Client>();
            this.masterList = new List<Master>();
            this.recordList = new List<Record>();
            this.salon = targetSalon;
        }
    }
}
