using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_proposto.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; set; }



        public Product(string name, double price)
        {
            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");

            Name = name;
            Price = price;
        }


    }
}
