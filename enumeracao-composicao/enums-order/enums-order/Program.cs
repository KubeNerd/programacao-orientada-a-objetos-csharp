using Course.Entities;
using System;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        public static void Main(string[] args) {

            Order order = new Order { 
                Id = 1, 
                Moment = DateTime.Now, 
                Status = OrderStatus.PendingPayment
            };


            Console.WriteLine(order);

            string text = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(text);
             
        
        }

    }
}