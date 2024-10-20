using System;
using exercicio_predicate_func.Entities;

namespace exercicio_predicate
{

    class Program
    {
        static string NameUpper(Product p)
        {

            return p.Name.ToUpper();
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.00));
            products.Add(new Product("HD Case", 80.90));
            products.Add(new Product("Monitor", 120.00));
            products.Add(new Product("HeadSet", 200.00));

            Func<Product, string> func = p => p.Name.ToUpper();
            
            List<string> result = products.Select(func).ToList();

            foreach (string s in result) 
            {
                Console.WriteLine(s);
            
            }
        
        }


    }

}