using Desafio003MediaNotas;
using System;

namespace CalculadoraMediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
           Aluno aluno = new Aluno();

           Console.WriteLine("Digite aqui o nome do aluno:");
           aluno.NomeAluno = Console.ReadLine();

           Console.WriteLine("Digite a nota do primeiro trimestre aqui:");
           aluno.PrimeiraNota = double.Parse(Console.ReadLine());

           Console.WriteLine("Digite a nota do segundo trimestre");

           aluno.SegundaNota = double.Parse(Console.ReadLine());

           Console.WriteLine("Digite a nota do terceiro trimestre");

           aluno.TerceiraNota = double.Parse(Console.ReadLine());


           Console.WriteLine(aluno.CalculaMediaAluno());
        }
    }
}