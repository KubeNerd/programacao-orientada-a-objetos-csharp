using System;
using System.Globalization;

namespace ConvertCelsiusToFahrenheit {
    class Program {
        static void Main(string[] args ) {
            //Fórmula	(9 °C × 9/5) + 32 = 48,2 °F
            Console.WriteLine("Entre com o valor em Celsius:");
            double GrausEmCelsius = double.Parse(Console.ReadLine());
            
            double GrausEmFahrenheit = (GrausEmCelsius * 9/5) + 32;
            
            Console.WriteLine($"{GrausEmFahrenheit}");
            
        }
    }
}