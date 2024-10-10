using System;
using System.Collections.Generic;

namespace exercicio_interfaces_domain_layer_design.Entities
{
    class Installment
    {
       public DateTime DueDate { get; set; }

       public double Amount {  get; set; }

      
       public Installment(DateTime dueDate, double amount) 
       {
            DueDate = dueDate;
            Amount = amount;
       }

    }
}
