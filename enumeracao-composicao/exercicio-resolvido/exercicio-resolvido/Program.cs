using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name:");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior):");

            WorkerLevel level;
            while (!Enum.TryParse(Console.ReadLine(), out level))
            {
                Console.WriteLine("Invalid level. Please enter Junior, MidLevel, or Senior:");
            }

            Console.WriteLine("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.WriteLine("Date (DD/MM/YYYY):");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
