using System;
using System.Collections.Generic;
using System.Text;

namespace W01_Moebel
{
    public class Tisch : Moebelstueck
    {
        private int Laenge { get; }
        private int Breite { get; }

        public Tisch(string bezeichung, double price, int laenge, int breite) : base(bezeichung, price)
        {
            this.Laenge = laenge;
            this.Breite = breite;
        }

        public override string ToString()
        {
            return "Bezeichung: " + this.Bezeichnung + ", Preis: " + this.Price + ", Laenge: " + this.Laenge + ", Breite: " + this.Breite;
        }
    }
}
