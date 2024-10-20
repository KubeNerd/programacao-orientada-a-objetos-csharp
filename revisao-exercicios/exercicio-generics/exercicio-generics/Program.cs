using exercicio_generics.Entities;
using exercicio_generics.Repository;


namespace exercicio_generics 
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IRepository<Product> produtoRepo = new Repository<Product>();
            produtoRepo.Add(new Product { Id = 1, Name = "Teclado" });
            produtoRepo.Add(new Product { Id = 2, Name = "Mouse" });

            IRepository<Client> clienteRepo = new Repository<Client>();
            clienteRepo.Add(new Client { Id = 1, Name = "João" });
            clienteRepo.Add(new Client { Id = 2, Name = "Maria" });

            var produto = produtoRepo.GetById(1);
            Console.WriteLine($"Produto: {produto?.Name}");

            var cliente = clienteRepo.GetById(2);
            Console.WriteLine($"Cliente: {cliente?.Name}");
        }
    }

}
