using System;
namespace ConsoleApp5.Task1
{
    internal class Builder : HumanBase
    {
        public int Work;

        public Builder(int w,string n, int a, string g) : base(n, a, g) 
        {
            Work = w;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"\n Work: {Work}");
        }
    }
}
