using System;

namespace ConsoleApp5.Task2
{
    internal class ForeignPassport : PassportBase
    {
        public string[] Visas { get; set; }
        public int VisasIndex { get; set; }

        public ForeignPassport(string lastName, string firstName, string dateOfBirth, string passportNumber, int maxVisas) : base(lastName, firstName, dateOfBirth, passportNumber)
        {
            Visas = new string[maxVisas];
            VisasIndex = 0;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Visa index: {VisasIndex}");
        }
    }
}
