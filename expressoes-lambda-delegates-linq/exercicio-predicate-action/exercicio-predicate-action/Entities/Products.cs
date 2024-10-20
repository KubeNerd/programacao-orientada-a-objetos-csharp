using System;
using System.Globalization;

namespace exercicio_predicate_action.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }
    }
}
