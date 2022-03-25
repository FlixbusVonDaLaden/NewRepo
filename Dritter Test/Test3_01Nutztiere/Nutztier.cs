using System;
using System.Collections.Generic;
using System.Text;

namespace Test3_01Nutztiere
{
    public class Nutztier
    {
        protected string name;
        protected int gewichtInKg;

        public Nutztier(string name, int gewichtInKg)
        {
            this.name = name;
            this.gewichtInKg = gewichtInKg;
        }

        public virtual string lieblingsfutter()
        {
            return "Mein Lieblingsfutter ist Heu";
        }
    }
}
