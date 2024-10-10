using System;
using System.Collections.Generic;

namespace exercicio_interfaces_domain_layer_design.Entities
{
    class Contract
    {
        public int Number {  get; set; }
        public DateTime Date { get; set; }

        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; } = new List<Installment>();/*Tipando e instanciando a lista*/


    }
}
