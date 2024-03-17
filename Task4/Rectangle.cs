using System;

namespace ConsoleApp5.Task4
{
    internal class Rectangle : ShapeBase
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

      
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
