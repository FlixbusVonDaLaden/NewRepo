using System;
using System.Collections.Generic;
using System.Text;

namespace Uebung3._1
{
    public class Nutztier : Object
    {
        protected string name;
        protected int gewichtInKg;

        public Nutztier(string name, int gewicht) 
        {
            this.name = name;
            this.gewichtInKg = gewicht;
        }

        public virtual string lieblingsfutter()
        {
            return "Mein Lieblingsfutter ist Heu";
        }

        public override string ToString()
        {
            return "Hallo, ich bin " + name + " und ich wiege " + gewichtInKg + " kg.";
        }

    }
}
