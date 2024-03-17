using System;

namespace ConsoleApp5.Task1
{
    internal class Pilot : HumanBase
    {
        public string Plane;

        public Pilot(string p, string n, int a, string g) : base(n, a, g)
        {
            Plane = p;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Plane: {Plane}");
        }
    }
}
