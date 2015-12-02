using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    class Service
    {
        public String name;
        public int price;
        public int duration;
        String id;
        List<Salon> salonList;
        List<Master> masterList;

        public Service(String name, int price, int duration, String id)
        {
            this.name = name;
            this.price = price;
            this.duration = duration;
            this.id = id;
        }
    }
}
