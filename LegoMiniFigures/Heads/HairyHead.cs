using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures.Heads
{
    class HairyHead : HeadBase
    {
        public override bool HasHair { get { return true; } }
        public string HairColor { get { return "Salt n Pepper"; } }
        public string Texture { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Doesn't Eat because of needy students");
        }
    }
}
