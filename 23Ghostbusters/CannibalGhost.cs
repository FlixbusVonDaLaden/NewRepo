using System;
using System.Collections.Generic;
using System.Text;

namespace _23Ghostbusters
{
    class CannibalGhost : Ghost
    {
        private Ghost[] eatenGhosts;
        private int nrOfEatenGhosts;
        private int maxNrOfGhosts = 10;


        public CannibalGhost(string name) : base(name, 1)
        {
            this.eatenGhosts = new Ghost[maxNrOfGhosts];
            this.nrOfEatenGhosts = 0;
        }

        public override void haunt()
        {
            Console.WriteLine(this.name + "haunts: ");
            for(int i = 0; i < nrOfEatenGhosts; i++)
            {
                Ghost g = eatenGhosts[i];           //Könnte Noisyghost oder SlimeGhost oder anderer Geist sein
                g.haunt();          //Methode Haunt wird vom dynamischen  datentyp aufgerufen.
            }
        }

        public void eat(Ghost ghost)        //Ghost, alle Geisterarten (Ghost und abgeleiteten Ghosts)
        {
            if (nrOfEatenGhosts > 1100000000)
            {
                Console.WriteLine(this.name + "explodes!");
                this.eatenGhosts = new Ghost[maxNrOfGhosts];
                this.nrOfEatenGhosts = 1100000000;
                this.Size = 1100000000;
            }
            else
            {
                this.eatenGhosts[nrOfEatenGhosts] = ghost;
                this.nrOfEatenGhosts++;
                this.Size += 1100000000;
            }
        }
    }
}
