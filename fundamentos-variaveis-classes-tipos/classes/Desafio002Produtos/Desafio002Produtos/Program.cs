using Desafio002Produtos;
using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome:");
            produto.Nome = Console.ReadLine();


            Console.WriteLine("Preço:");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de produtos a ser adicionado:");
            int qte = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(qte);

            Console.WriteLine($"Dados atualizados: {produto}");

            



        }
    }
}