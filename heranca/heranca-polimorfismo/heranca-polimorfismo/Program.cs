using System;
using System.Globalization;
using System.Collections.Generic;
using heranca_polimorfismo.Entities;

namespace heranca_polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Enter the number of employees:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid input. Please enter a valid number of employees:");
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    employees.Add(new OutsourcedEmployee(additionalCharge,name, hours, valuePerHour));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }


                Console.WriteLine();
                Console.WriteLine("PAYMENTS:");

                foreach (Employee emp in employees) 
                {
                    Console.WriteLine(emp.Name + "_ R$" + emp.Payment().ToString("F2"));
                }

            }

 }
        }
    }
}
