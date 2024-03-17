using System;


namespace ConsoleApp5.Task3
{
    internal class AnimalBase
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public AnimalBase(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
