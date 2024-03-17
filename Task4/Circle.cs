using System;
namespace ConsoleApp5.Task4
{
    internal class Circle : ShapeBase
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
