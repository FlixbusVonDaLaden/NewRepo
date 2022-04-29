using System;
using System.Collections.Generic;
using System.Text;

namespace _28Glueckswurf
{
    class Wuerfel
    {
        private Random rand = new Random();
        public int wuerfeln()
        {
            return rand.Next(1, 7);
        }
    }
}
