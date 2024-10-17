using System;

public class ValidarNumeroPar
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero aqui:");
        int Number = int.Parse(Console.ReadLine());
        
        if( Number % 2 == 0){
            Console.WriteLine($"O numero digitado: {Number} eh par!");
        } else {
            Console.WriteLine($"O numero digitado: {Number} eh impar!");
        }
        
    }
}