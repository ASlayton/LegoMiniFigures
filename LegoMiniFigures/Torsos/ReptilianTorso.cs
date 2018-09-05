using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures.Torsos
{
    class ReptilianTorso : Torso
    {
        public string ScaleShape { get; set; }

        public void Dance()
        {
            Console.WriteLine("*Breakdances vigorously*");
        }

        public void Twist()
        {
            Console.WriteLine("A little bit louder now.");
        }
    }
}
