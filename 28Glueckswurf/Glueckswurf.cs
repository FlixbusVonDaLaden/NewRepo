using System;

namespace _28Glueckswurf
{
    public class Glueckswurf
    {
        public int Guthaben { get; private set; }
        public int[] Wuerfelergebnis { get; }

        private Wuerfel wuerfel = new Wuerfel();
        public Glueckswurf(int guthaben)
        {
            Wuerfelergebnis = new int[3];
            this.Guthaben = guthaben;
        }

        //Startguthaben
        //Einsatz vom Benutzer
        //Glückszahl vom Benutzer
        //würfeln
        //Ergenbis anzeugen
        //Gewinnauswertung
        //Guthaben aktualisieren

        private void wuerfeln()
        {
            for (int i = 0; i < 3; i++)
            {
                Wuerfelergebnis[i] = wuerfel.wuerfeln();
            }
        }
        public int spielen(int einsatz, int glueckszahl)
        {
            this.Guthaben -= einsatz;
            this.wuerfeln();

            int gewinn = 0;
            int countergewinn = 0;
            for(int i = 0; i <= 2; i++)
            {
                if(glueckszahl == Wuerfelergebnis[i])
                {
                    countergewinn ++;
                }
            }
            if(countergewinn > 0)
            {
                gewinn = countergewinn * einsatz + einsatz;
            }
            this.Guthaben += gewinn;
            return gewinn;
        }
    }
}
