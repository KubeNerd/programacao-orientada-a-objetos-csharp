using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfaces_domain_layer_design.Entities
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model) 
        {
            Model = model;
        }
    }
}
