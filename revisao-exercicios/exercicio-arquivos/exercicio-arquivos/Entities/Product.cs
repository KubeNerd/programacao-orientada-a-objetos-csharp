using System;
using System.Collections.Generic;
using System.Linq;
using exercicio_arquivos.Services;

namespace exercicio_arquivos.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public  int Quantity { get; set; }


        public IServiceCalculate _serviceCalculate;


        public Product()
        { }
        public Product(string name, double price, int quantity, IServiceCalculate serviceCalculate) 
        { 
     
            Name = name;
            Price = price;
            Quantity = quantity;
            _serviceCalculate = serviceCalculate;

        }

        public double GetTotalPrice() 
        {
            return _serviceCalculate.Total(Price, Quantity);
        
        }



        public string GetProductSummary()
        {
            return $"{Name} - Valor Total: {GetTotalPrice():C}";
        }


        public override string ToString()
        {
            return $"Produto: {Name}, Preço: {Price}, Quantidade: {Quantity}";
        }

    }
}
