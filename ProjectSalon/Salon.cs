using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    class Salon
    {
        public String address;
        public String name;
        String id;
        List<Master> masterList;
        List<Service> serviceList;
        List<Client> clientList;

        public Salon(String address, String name, String id)
        {
            this.address = address;
            this.id = id;
            this.name = name;
        }

    }
}
