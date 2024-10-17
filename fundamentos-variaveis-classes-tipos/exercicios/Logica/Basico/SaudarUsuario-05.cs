
using System;

public class Saudacao
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Digite seu nome aqui para continuar: Ex: Joao");
        string InputUserName = Console.ReadLine();
        string UserName = InputUserName.ToUpper();
  
        Console.WriteLine ($"Seja muito bem vindo {UserName}");
    }
}