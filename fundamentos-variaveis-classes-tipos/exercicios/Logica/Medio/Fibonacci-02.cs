using System;
/*
Fórmula de Fibonacci:
O primeiro número é 0.
O segundo número é 1.
A partir do terceiro número, cada número é a soma dos dois anteriores:
n 
F(n)=F(n−1)+F(n−2)

*/
public class FibonacciSequenciaGPT
{
    public static void Main(string[] args)
    {
        int num1 = 0; // Primeiro número da sequência
        int num2 = 1; // Segundo número da sequência

        Console.WriteLine("Os primeiros 10 números da sequência de Fibonacci são:");

        // Imprime os dois primeiros números da sequência
        Console.Write(num1 + " " + num2 + " ");

        // Calcula e imprime os próximos 8 números
        for (int i = 3; i <= 10; i++)
        {
            int num3 = num1 + num2; // Próximo número é a soma dos dois anteriores
            Console.Write(num3 + " "); // Exibe o número
            num1 = num2; // Atualiza o valor de num1
            num2 = num3; // Atualiza o valor de num2
        }
    }
}
