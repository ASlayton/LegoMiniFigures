using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures.Heads
{
    class BaldHead: HeadBase
    {
        public override bool HasHair { get { return false; } }
        public int SmoothnessLevel { get; set; }

        public override void Talk()
        {
            Console.WriteLine("Hi, I'm a Baldi!");
        }

        public override void Eat()
        {
            Console.WriteLine("*Eats a burrito*");
        }
    }
}
