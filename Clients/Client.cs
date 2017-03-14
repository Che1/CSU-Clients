using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clients
{
    class Client : Person
    {
        private List<string> salaryHistory;
        private int IDclient;
        

        public Client(string name, string lastname, int age, string sex, DateTime birthday)
        {
            this.first_name = name;
            this.last_name = lastname;
            this.age = age;
            this.sex = sex;
            this.birthday = birthday;
        }


        public void Bying(string item, float price)
        {

        }
    }
}
