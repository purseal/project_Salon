using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalon
{
    class Master
    {
        public String name;
        int salary;
        String id;
        Salon[] employerList = new Salon[3];
        List<Service> serviceList;
        List<Record> recordList;

        public Master(String name, int salary, String id)
        {
            this.name = name;
            this.salary = salary;
            this.id = id;
        }


    }
}
