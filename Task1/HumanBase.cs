using System;
namespace ConsoleApp5.Task1
{
    internal class HumanBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public HumanBase()
        {
            Name = "Name";
            Age = -1;
            Gender = "None";
        }

        public HumanBase(string n, int a, string g)
        {
            Name = n; Age = a; Gender = g;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Name {Name}. Age {Age} Gender {Gender}.");
        }
    }
}
