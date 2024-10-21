using exercicio_resolvido_linq.Entities;
using System.Globalization;
using System.Linq;
using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter full file path here:");
        string localPath = Console.ReadLine();


        List<Product> product = new List<Product>();


        try
        {
            using (StreamReader sr = File.OpenText(localPath))
            {
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(",");

                        string productName = fields[0];
                        double productPrice = double.Parse(fields[1], CultureInfo.InvariantCulture);


                        product.Add(new Product()
                        {
                            Name = productName,
                            Price = productPrice,
                        });

                    }

                    sr.Close();

                    
                    var avg = product.Select(x => x.Price).DefaultIfEmpty(0.0).Average();

                    var names = product.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                    
                    foreach (string name in names ) 
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}