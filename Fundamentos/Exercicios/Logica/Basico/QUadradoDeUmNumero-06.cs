using System;

public class QuadradoDeUmNumero
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero aqui:");
        int NumberInput = int.Parse(Console.ReadLine()); // Converte a entrada para inteiro
        
        int ResultNumber = NumberInput * NumberInput; // Calcula o quadrado do número
        
        Console.WriteLine($"O quadrado de {NumberInput} é {ResultNumber}.");
    }
}
