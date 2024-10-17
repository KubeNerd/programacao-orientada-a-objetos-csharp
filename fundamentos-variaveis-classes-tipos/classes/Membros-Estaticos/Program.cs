using System;
using System.Globalization

namespace Curse
{
  class Program
  {
    
    // Calculadora calc = new Calculadora();

    static void Main(string[] args){
        Console.WriteLine("Digite aqui o valor de raio:");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
        double circ = Circunferencia(raio);
        double volume = Volume(raio);

        Console.WriteLine("Circunferência:" + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI:", PI.ToString("F2", CultureInfo.InvariantCulture));
    }


  }
}