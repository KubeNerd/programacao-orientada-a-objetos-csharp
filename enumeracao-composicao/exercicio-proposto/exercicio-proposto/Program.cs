using System;
using exercicio_proposto.Entities;
using exercicio_proposto.Entities.Enums;

namespace exercicio_proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");

            Console.WriteLine("Name: Ex: (Alex Green)");
            string name = Console.ReadLine();

            Console.WriteLine("E-mail: Ex: (alex.green@example.com)");
            string email = Console.ReadLine();

            Console.WriteLine("Birth date (DD/MM/YYYY):");
            DateTime birthDate;
            while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine("Invalid date format. Please enter again (DD/MM/YYYY):");
            }

            Client client = new Client(name, email, birthDate);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Status (PendingPayment, Processing, Shipped, Delivered): ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine(), true);

            Order order = new Order(DateTime.Now, orderStatus, client);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Order moment: {order.Moment}");
            Console.WriteLine($"Order status: {order.Status}");
            Console.WriteLine($"Client: {order.Client.Name} ({order.Client.BirthDate:dd/MM/yyyy}) - {order.Client.Email}");
            Console.WriteLine("Order items:");

            foreach (var item in order.Items)
            {
                Console.WriteLine($"{item.Product.Name}, ${item.Product.Price:F2}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal():F2}");
            }

            Console.WriteLine($"Total price: ${order.Total():F2}");
        }
    }
}
