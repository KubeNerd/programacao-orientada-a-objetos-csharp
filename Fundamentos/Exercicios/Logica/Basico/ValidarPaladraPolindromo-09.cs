// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class ValidarPalavrasGPT
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra de sua escolha:");
        
        string Palavra = Console.ReadLine();
    
        string RemoveEspacosDaPalavra = Palavra.Replace(" ", "").ToLower();
        
        
        char[] palavraArray = RemoveEspacosDaPalavra.ToCharArray();

        
        Array.Reverse(palavraArray);
        
        
        string palavraInvertida = new string(palavraArray);
        
        
        if (Palavra == palavraInvertida)
        {
            Console.WriteLine("A palavra digitada é um palíndromo!");
        }
        else
        {
            Console.WriteLine("A palavra digitada não é um palíndromo.");
        }
    }
}