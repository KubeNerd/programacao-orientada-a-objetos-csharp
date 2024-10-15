using System;
using System.IO;
using exercicio_arquivos.Entities;
using exercicio_arquivos.Services;

namespace exercicio_arquivos
{
    class Program
    {
        static void Main(string[] args)

        {

            string currentDirectory = Directory.GetCurrentDirectory();

            string pathSourceContent = Path.Combine(currentDirectory, "produtos_vendidos.csv");

  
            string folderPath = Path.Combine(currentDirectory, "out");
            string pathSummaryContent = Path.Combine(folderPath, "summary_products.txt");


            try {
                IServiceCalculate serviceCalculate = new ServiceCalculate();

                List<Product> summaryList = new List<Product>();

                using (var sr = new StreamReader(pathSourceContent)) {

                    while (!sr.EndOfStream) 
                    {
                        string line = sr.ReadLine();
                        string[] productsSold = line.Split(';');

                        string name = productsSold[0];
                        double price = double.Parse(productsSold[1]);
                        int quantity = int.Parse(productsSold[2]);

                        Product product = new Product(name, price, quantity, serviceCalculate);

                        summaryList.Add(product);


                    }

                    try
                    {
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                            Console.WriteLine("The 'out' folder was successfully created!");
                        }
                        else
                        {
                            Console.WriteLine("The 'out' folder already exists.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error creating the folder: {e.Message}");
                    }




                    using (StreamWriter writer = new StreamWriter(pathSummaryContent))
                    {
                        foreach (var product in summaryList)
                        {

                            writer.WriteLine($"{product.Name} - Valor Total: {product.GetProductSummary():C}");
                        }
                    }

                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
