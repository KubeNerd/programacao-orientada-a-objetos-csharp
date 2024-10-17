using System;

namespace exercicio_01_generics
{
    class Program
    {
        static void Main(string[] args)
        {
           PrintService<string> printService = new PrintService<string>();
           Console.Write("How many values?");
           int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);

                Console.WriteLine("First: " + printService.First());
            }
        }
    }
}