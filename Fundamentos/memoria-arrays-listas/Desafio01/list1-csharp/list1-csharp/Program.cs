using list1_csharp;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Quantos empregados você deseja cadastrar?");
            int n = int.Parse(Console.ReadLine());
            List<Empregado> empregados = new List<Empregado>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Empregado #" + i + ":");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                empregados.Add(new Empregado(id, nome, salario));

            }

            Console.WriteLine("Digite o id do usuário o qual você deseja aumentar o salario:");
            int buscaId = int.Parse(Console.ReadLine());

            Empregado emp = empregados.Find(e => e.Id == buscaId);

            if (emp != null)
            {
                Console.Write("Digite o percentual de aumento: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalario(percentage);
            }
            else
            {
                Console.WriteLine("Este ID de empregado não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de empregados atualizada:");
            foreach (Empregado obj in empregados)
            {
                Console.WriteLine(obj);
            }

        }

    }

}