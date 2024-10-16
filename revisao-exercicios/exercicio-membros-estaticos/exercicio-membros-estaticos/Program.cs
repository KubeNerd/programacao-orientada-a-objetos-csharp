using System;
using System.Globalization;

namespace exercicio_membros_estaticos
{
  class Program
  {
    static void Main(string[] args)
    {
            Console.WriteLine("How much dollar quote today ?");
            double dolarQuoteToday = double.Parse(Console.ReadLine());

            Console.WriteLine("How much dollars, do you want buy ?");
            int quantityDolarToBuy = int.Parse(Console.ReadLine());

            DollarCalculator.DollarQuote = dolarQuoteToday;
            DollarCalculator.DollarQuantity = quantityDolarToBuy;

            double dolar = DollarCalculator.Total();

            Console.WriteLine(dolar);

        }       
        
    }
}