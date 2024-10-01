using System;
using System.Globalization;
using exercicio_proposto.Entities;
using exercicio_proposto.Entities.Exceptions;



namespace exercicio_proposto { 
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");

            Console.WriteLine("Account number:");
            double number = int.Parse(Console.ReadLine());

            Console.WriteLine("Holder's name:");
            string name = Console.ReadLine();

            Console.WriteLine("Inicial balance");
            double balance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter amount for withdraw:");
            double withDrawLimit = double.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}