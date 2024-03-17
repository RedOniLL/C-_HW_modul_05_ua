using System;


namespace ConsoleApp5.Task1
{
    internal class Sailor : HumanBase
    {
        public string Ship;

        public Sailor(string sh, string n, int a, string g) : base(n, a, g)
        {
            Ship = sh;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Ship: {Ship}");
        }

    }
}
