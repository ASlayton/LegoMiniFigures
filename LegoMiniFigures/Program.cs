using LegoMiniFigures.Heads;
using LegoMiniFigures.Torsos;
using System;

namespace LegoMiniFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new HairyHead();
            var reptileBody = new ReptilianTorso();
            reptileBody.Color = "brown";

            var figure = new MiniFigure(head, reptileBody);
            figure.Greet();
            figure.TakeABreak();

            Console.ReadLine();
        }
    }
}
