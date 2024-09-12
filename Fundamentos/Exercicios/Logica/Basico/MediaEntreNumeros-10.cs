
using System;

public class MediaEntreNumeros
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro numero. Ex: 1:");
        double Primeiro = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o primeiro numero. Ex: 1:");
        double Segundo = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o primeiro numero. Ex: 1:");
        double Terceiro = int.Parse(Console.ReadLine());
        
        double MediaEntreNumeros = Primeiro + Segundo + Terceiro;
        Console.WriteLine($"A Média entre os numeros digitados é: {MediaEntreNumeros}");

    }
}