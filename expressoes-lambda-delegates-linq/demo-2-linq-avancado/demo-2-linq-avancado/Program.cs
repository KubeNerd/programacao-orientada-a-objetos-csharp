using demo_2_linq_avancado.Entities;
using System;

namespace demo_2_linq_avancado
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


            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900
                     select p;


            foreach (Product p in r1) 
            {
                //Print<double>("Tier 1", p.Price);
                Console.WriteLine(p.Name);
            }


            var r2 = from p in products
                     where p.Name[0] == 'C'
                     select new
                     {
                         p.Name,
                         p.Price,
                         CategoryName = p.Category

                     };


            var r3 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;

            var r4 = (from p in r3 select p)
                .Skip(2)
                .Take(3);

            foreach (IGrouping<Category, Product> group in r4) 
            {
                Console.WriteLine("Category" + group.Key.Name + ":");
                foreach ( Product p in group) 
                {
                    Console.WriteLine(p);
                }
            }

        }
    }
}