using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_proposto.Entities
{
    class Client
    {
        public string Name { get; private set; }
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be null or empty.");

            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return + $"{Name}";
             
        }


    }
}
