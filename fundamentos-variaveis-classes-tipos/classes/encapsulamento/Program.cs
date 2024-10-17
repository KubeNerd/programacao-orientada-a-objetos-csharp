using System;

namespace Vendas
{
    class Produto
    {
        // Propriedades privadas
        private string _nomeProduto;
        private double _precoProduto;
        private int _quantidadeProduto;

        // Propriedades públicas com encapsulamento
        public string NomeProduto
        {
            get { return _nomeProduto; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 1)
                {
                    _nomeProduto = value;
                }
                else
                {
                    Console.WriteLine("Nome do produto é inválido.");
                }
            }
        }

        public double PrecoProduto
        {
            get { return _precoProduto; }
            set { _precoProduto = value; }
        }

        public int QuantidadeProduto
        {
            get { return _quantidadeProduto; }
            set { _quantidadeProduto = value; }
        }

        // Construtor vazio
        public Produto() {}

        // Métodos para acessar e modificar propriedades (opcional)

        /*
           Métodos set em C# normalmente não possuem um tipo de retorno (devem ser void). Atualmente, você está tentando retornar uma string, o que não é uma prática comum para um setter.
           Se o nome não atender às condições, o método não retorna nada, o que causa um erro. Em métodos que não têm um valor de retorno explícito, eles devem ser definidos como void
    
        */
        public string GetNomeProduto()
        {
            return _nomeProduto;
        }

        public void SetNomeProduto(string nome)
        {
            NomeProduto = nome; // Reutilizando a propriedade
        }
    }
}

namespace Vendas
{
    public class Vendedor
    {
        public static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.SetNomeProduto("Pascoa");

            // Exibe o nome do produto para verificar se a atribuição foi bem-sucedida
            Console.WriteLine($"Nome do produto: {produto.GetNomeProduto()}");
        }
    }
}
