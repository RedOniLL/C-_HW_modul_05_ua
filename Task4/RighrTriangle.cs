using System;

namespace ConsoleApp5.Task4
{
    class RightTriangle : ShapeBase
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(double _base, double height)
        {
            Base = _base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
