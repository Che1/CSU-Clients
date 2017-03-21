using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class PrefferedClient:Client
    {
        private double spendMoney;
        private double discount;

        public PrefferedClient(string name, string lastname, string sex, DateTime birthday, List<Product> salaryProducts ) : base(name, lastname, sex, birthday)
        {

        }
    }
}
