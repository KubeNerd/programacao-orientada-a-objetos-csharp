using System;
using System.Collections.Generic;
using exercicio_proposto.Entities.Enums;

namespace exercicio_proposto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }


        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client  = client;
        }

        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            Items.Add(item);

        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.subTotal();
            }
            return total;
        }

        public OrderStatus GetOrderStatus()
        {
            return Status;
        }


    }
}
