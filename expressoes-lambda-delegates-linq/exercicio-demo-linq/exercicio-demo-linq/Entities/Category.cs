using System;
using System.Collections.Generic;
using exercicio_demo_linq.Entities;

namespace exercicio_demo_linq.Entities
{
    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }
        public Category() 
        { 
        
        
        }

        public Category(int id, string name, int tier) 
        {
            Id = id;
            Name = name;
            Tier = tier;
        }
    }
}
