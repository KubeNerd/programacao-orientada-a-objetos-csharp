using System;
using System.Globalization;
using System.Collections.Generic;
using exercicio_demo_linq.Entities;

namespace exercicio_demo_linq
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection) 
        {
            
            Console.WriteLine(message);

            foreach (T obj in collection) 
            {
                Console.WriteLine(obj);
            }
        
        }


        public static void Main(string[] args)
        {
            Category c1 = new Category()
            {
                Id = 1,
                Name = "Electronics",
                Tier = 1
            };

            Category c2 = new Category()
            {
                Id = 2,
                Name = "Tools",
                Tier = 2
            };

            Category c3 = new Category()
            {
                Id = 3,
                Name = "Computers",
                Tier = 3
            };

            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Mouse",
                    Price = 129.90,
                    Category = c3
                },
                new Product()
                {
                    Id = 2,
                    Name = "Printer",
                    Price = 799.00,
                    Category = c3
                },
                new Product()
                {
                    Id = 3,
                    Name = "Sound Bar",
                    Price = 299.90,
                    Category = c1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Hammer",
                    Price = 79.90,
                    Category = c2
                },
                new Product()
                {
                    Id = 5,
                    Name = "Smartphone",
                    Price = 1999.90,
                    Category = c1
                },
                new Product()
                {
                    Id = 6,
                    Name = "Laptop",
                    Price = 3499.99,
                    Category = c3
                },
                new Product()
                {
                    Id = 7,
                    Name = "Drill",
                    Price = 299.99,
                    Category = c2
                },
                new Product()
                {
                    Id = 8,
                    Name = "Tablet",
                    Price = 1299.90,
                    Category = c3
                },
                new Product()
                {
                    Id = 9,
                    Name = "TV",
                    Price = 2499.99,
                    Category = c1
                },
                new Product()
                {
                    Id = 10,
                    Name = "Screwdriver Set",
                    Price = 49.90,
                    Category = c2
                }
            };


            
            var r1 = products.Where(a => a.Category.Tier == 1);

            foreach (Product p in r1)
            {
                Console.WriteLine("Pegando todos os produtos do Tier 1:", p.Name);
            
            }

            var r2 = products
                  .Where(b => b.Category.Name == "Tools")
                  .Select(c => c.Name);

            Console.WriteLine("Todos os produtos da categoria tools:", r2);


            var r3 = products.Where(a => a.Price >= 100).Select(p => new
            {
                p.Name,
                p.Price,
            });
            Console.WriteLine("Todos os produtos com o preço maior ou igual a 100, porém apenas o nome e o preço:", r3);


            var r4 = products
                .Where(p => p.Category.Tier != 1)
                .OrderBy(p => p.Name).ToList();


            // Pula 1 elemento. Pega os 4 primeiros.
            var r5 = r4.Skip(1).Take(4);


            // O primeiro, ou o padrão
            var r6 = products.FirstOrDefault();

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();

            // Apenas 1 ou o padrão - Single or default test1
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();


        }
    }
}