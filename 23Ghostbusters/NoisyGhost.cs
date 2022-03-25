using System;
using System.Collections.Generic;
using System.Text;

namespace _23Ghostbusters
{
    public class NoisyGhost : Ghost
    {
        public NoisyGhost(string name) : base(name, 0)   //Noisy Ghost ist unsichtbar und hat daher Größe 0
        {

        }

        public override void haunt()
        {
            Console.WriteLine("Pooooooooooooh......Poooooooooooh..........Pooooooooooooh");
        }

    }
}
