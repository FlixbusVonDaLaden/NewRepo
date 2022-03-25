using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung3._1
{
    public class Ziege : Nutztier
    {
        private int milchleistung;
        public Ziege(string name, int gewicht, int milchleistung) : base(name, gewicht)
        {
            this.milchleistung = milchleistung;
        }

        public int MilchleistungInKg
        {
            get
            {
                return this.milchleistung;
            }
            set
            {
                this.milchleistung = value;
            }
        }
        public override string lieblingsfutter()
        {
            return "Mein Lieblingsfutter ist Heu";
        }
    }
}
