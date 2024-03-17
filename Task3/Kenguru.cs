using System;

namespace ConsoleApp5.Task3
{
    internal class Kenguru : AnimalBase
    {
        public string JumpHeight;
        public Kenguru(string jumpheight, string name, int age) : base(name,  age)
        {
            JumpHeight = jumpheight;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The Kenguru makes a sound.");
        }
    }
}
