using System;
using exercicio_predicate.Entities;

namespace exercicio_predicate
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.00));
            products.Add(new Product("HD Case", 80.90));
            products.Add(new Product("Monitor", 120.00));
            products.Add(new Product("HeadSet", 200.00));


            products.RemoveAll(a => a.Price >= 100.00);


            foreach (Product product in products) {
                Console.WriteLine(product);
            }


        }

        public static bool ProductTest(Product p) 
        {
            return p.Price >= 100.0;  
        }

    }
}