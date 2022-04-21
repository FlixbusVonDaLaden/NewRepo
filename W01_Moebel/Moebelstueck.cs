using System;
using System.Collections.Generic;
using System.Text;

namespace W01_Moebel
{
    public class Moebelstueck
    {
        protected string Bezeichnung { get; }
        public double Price { get; }

        public Moebelstueck(string bezeichunung, double price)
        {
            this.Bezeichnung = bezeichunung;
            this.Price = price;
        }



    }
}
