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
        private List<Product> salaryHistory;
        private int IDclient;
        

        public Client(string name, string lastname, string sex, DateTime birthday)
        {
            this.first_name = name;
            this.last_name = lastname;
            this.sex = sex;
            this.birthday = birthday;
            this.salaryHistory = new List<Product>();
        }

        public void AddToDatabase()
        {
            
        }


        public void Bying(string item, float price)
        {
            salaryHistory.Add(new Product(item,price));
        }
    }
}
