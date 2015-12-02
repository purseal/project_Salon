using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectSalon
{
    class Client
    {
        public String name;
        public DateTime birth;
        List<Salon> salons;

        public Client(String name, DateTime birth)
        {
            this.name = name;
            this.birth = birth;
        }


    }
}
