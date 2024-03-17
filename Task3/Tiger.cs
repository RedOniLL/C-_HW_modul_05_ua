using System;

namespace ConsoleApp5.Task3
{
    internal class Tiger : AnimalBase
    {
        public string StripePattern { get; set; }

        public Tiger(string pattern, string name, int age) : base(name, age) 
        {
            StripePattern = pattern;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The tiger makes a sound.");
        }
    }
}
