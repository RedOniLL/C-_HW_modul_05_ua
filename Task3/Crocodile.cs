using System;

namespace ConsoleApp5.Task3
{
    internal class Crocodile : AnimalBase
    {
        public string Habitat { get; set; }
        public Crocodile(string habitat, string name, int age) : base(name, age)
        {
            Habitat = habitat;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The Crocodile makes a sound.");
        }
    }
}
