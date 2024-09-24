using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_proposto.Entities
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; private set; }


        public double subTotal() {
            return quantity * price;
        
        }
    }
}
