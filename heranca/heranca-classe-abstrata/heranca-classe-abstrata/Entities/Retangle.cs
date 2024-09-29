using System;
using System.Drawing;

namespace heranca_classe_abstrata.Entities
{
    class Retangle: Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public Retangle(Color color) : base(color)
        { }
        
        
        public override double Area()
        {
            return Width * Height;
        }
    }
}
