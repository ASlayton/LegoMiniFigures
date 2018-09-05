using System;

namespace LegoMiniFigures.Heads
{
    abstract class HeadBase
    {
        public abstract bool HasHair { get; }

        public virtual void Talk()
        {
            Console.WriteLine("I'm a talking head.");
        }

        public abstract void Eat();
    }
}
