using DesafioObjetos_01;
using System;

namespace DesafioOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pessoa 1
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Digite idade da primeira pessoa:");
            pessoa1.idade = double.Parse(Console.ReadLine());

 

            Console.WriteLine(pessoa1.nome);

            // Segunda Pessoa

            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            pessoa2.nome = Console.ReadLine();

            Console.WriteLine("Digite idade da primeira pessoa:");
            pessoa2.idade = double.Parse(Console.ReadLine());


            // Encontrar pessoa mais velha entre as duas


            if (pessoa1.idade == pessoa2.idade)
            {
                Console.WriteLine($"{pessoa1.nome.ToUpper()} e {pessoa2.nome.ToUpper()} tem a mesma idade.");
            }
            else if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine($"{pessoa1.nome.ToUpper()} é mais velho(a)");
            } else
            {
                Console.WriteLine($"{pessoa2.nome.ToUpper()} é mais velho(a)");
            }


        }
    }
}