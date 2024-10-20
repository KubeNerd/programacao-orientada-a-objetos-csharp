using System;

namespace exercicio_generics.Entities
{
    class Product: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
