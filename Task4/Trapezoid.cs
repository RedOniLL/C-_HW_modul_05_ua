using System;
namespace ConsoleApp5.Task4
{
    internal class Trapezoid : ShapeBase
    {
        public double TopBase { get; set; }
        public double BottomBase { get; set; }
        public double Height { get; set; }

        public Trapezoid(double topBase, double bottomBase, double height)
        {
            TopBase = topBase;
            BottomBase = bottomBase;
            Height = height;
        }

      
        public override double CalculateArea()
        {
            return 0.5 * (TopBase + BottomBase) * Height;
        }
    }

}
