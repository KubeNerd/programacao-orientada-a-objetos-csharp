using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_proposto.Entities
{
    class Client
    {
        public  string Name { get; private set; }
        public string Email { get; set; }


        public Client(string name, string email) {
            Name = name;
            Email = email;
        }


    }
}
