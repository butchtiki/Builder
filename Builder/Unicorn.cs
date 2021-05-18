using System;
namespace Builder
{
    public class Unicorn : Mount
    {
        public Unicorn(string name): base (name)
        {
        }

        public override void Move(int meters)
        {
            Console.WriteLine("Unicorn Moving");
        }
    }
}
