using LegoMiniFigures.Heads;
using LegoMiniFigures.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures 
{
    class MiniFigure
    {
        private readonly HeadBase _head;
        private readonly Torso _torso;

        public MiniFigure(HeadBase head, Torso torso)
        {
            _head = head;
            _torso = torso;
        }

        public void Greet()
        {
            _head.Talk();
        }

        public void TakeABreak()
        {
            _head.Eat();
            switch (_torso)
            {
                case BirdTorso bird :
                    bird.Fly();
                    bird.Dance();
                    bird.Fly();
                    break;
                case ReptilianTorso reptile :
                    reptile.Dance();
                    break;
                case Torso boringTorso :
                    Console.WriteLine($"The boring torso was {boringTorso.Color} and has {boringTorso.NumberOfArms} arms.");
                    break;
            }
        }


    }
}
