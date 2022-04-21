using System;
using System.Collections.Generic;
using System.Text;

namespace W01_Moebel
{
    public class Einkaufskorb
    {
        private Moebelstueck[] articels = new Moebelstueck[100];

        public Einkaufskorb() { }


        int nrOfItems = 0;

        public void addMoebelestück(Moebelstueck moebel)
        {
            articels[nrOfItems] = moebel;
            nrOfItems++;
        }

        public void printMoebel()
        {
            for (int i = 0; i < this.nrOfItems; i++)
            {
                Console.WriteLine(articels[i].ToString());
            }
        }

        public double getPriceTotal()
        {
            double preis = 0;
            for (int i = 0; i < this.nrOfItems; i++)
            {
                preis += articels[i].Price;
            }
            return preis;
        }


    }
}
