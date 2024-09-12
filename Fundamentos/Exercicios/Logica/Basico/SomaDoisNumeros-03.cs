using System;

public class SomaNumeros
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo!");
        Console.WriteLine("Digite 2 numeros, pode ser em sequencia. Ex: 8 9");
        
        string[] UserInputData = Console.ReadLine().Split(" ");
        double FirstNumber = double.Parse(UserInputData[0]);
        double SecoundNumdber = double.Parse(UserInputData[1]);
        double ResultSoma = FirstNumber + SecoundNumdber; 
        
        Console.WriteLine(ResultSoma);
    }
}