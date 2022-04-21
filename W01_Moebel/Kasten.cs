using System;
using System.Collections.Generic;
using System.Text;

namespace W01_Moebel
{
    public class Kasten : Moebelstueck
    {
        private int Volumen { get; }
        private int AnzahlTueren { get; }

        public Kasten(string bezeichung, double price, int volumen, int anzahlTueren) : base(bezeichung, price)
        {
            this.Volumen = volumen;
            this.AnzahlTueren = anzahlTueren;
        }

        public override string ToString()
        {
            return "Bezeichung: " + this.Bezeichnung + ", Preis: " + this.Price + ", Volumen: " + this.Volumen + ", Anzahl der Tueren: " + this.AnzahlTueren;
        }
    }
}

