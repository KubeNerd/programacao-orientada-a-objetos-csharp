using System;
using System.Drawing;

namespace heranca_classe_abstrata.Entities
{
    class Circle: Shape
    {
        public double Radius { get; set; }
        public Circle(double radius, Color color)
            : base(color)
        { 
            Radius = radius;
        }


        public override double Area()
        {
            return Radius;
        }

    }
}
