using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class PrefferedClient:Client
    {
        public PrefferedClient(string name, string lastname, string sex, DateTime birthday) : base(name, lastname, sex, birthday)
        {
        }
    }
}
