using System;

public class Tabuada
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero. Ex: 1:");
        int Numero = int.Parse(Console.ReadLine());
        
        for(int i = 1; i < 10; i++){
            if(Numero  >= 1){
                Console.WriteLine($"{Numero} * {i} = {Numero * i }");
            }
            
        }
    
    }
}