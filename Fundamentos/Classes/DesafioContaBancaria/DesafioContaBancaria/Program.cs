using DesafioContaBancaria;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.WriteLine("Entre com o número da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do titular da conta:");
            string titular = Console.ReadLine();

            Console.WriteLine("Deseja efetuar um deposito inicial ?");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Digite o valor desejado para depósito:");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, depositoInicial);

            }
            else {
                conta = new ContaBancaria(numero, titular, 0.00);

            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito:");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);


        }
    }
}