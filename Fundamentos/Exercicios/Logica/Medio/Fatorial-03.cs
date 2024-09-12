using System;

public class FatorialGPT
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Não existe fatorial para números negativos.");
        }
        else
        {
            int fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i; // Multiplica o valor atual de fatorial por i
            }

            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
    }
}
