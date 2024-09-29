using System;
using heranca_classe_abstrata.Entities.Enums;

namespace heranca_classe_abstrata.Entities
{
    abstract class Shape
    {
        private System.Drawing.Color color;

        public Color Color {  get; set; } 
    
        public Shape() 
        {
        
        }
        public Shape(Color color)
        {
            Color = color;
        }

        protected Shape(System.Drawing.Color color)
        {
            this.color = color;
        }

        public abstract double Area();

    }
}
