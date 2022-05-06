using System;

namespace _28Glueckswurf
{
    public class Glueckswurf
    {
        public int Guthaben { get; private set; }
        private Wuerfel wuerfel = new Wuerfel();
        public int[] Wuerfelergebnis { get; }

        public Glueckswurf(int guthaben)
        {
            this.Guthaben = guthaben;
            this.Wuerfelergebnis = new int[3];
        }
        public int spieleEinSpiel(int gluecksZahl, int einsatz)
        {
            // Benutzer muss eine Zahl wählen
            // Benutzer muss Einsatz wählen
            // Würfeln mit 3 Würfel
            // Gewinnauswertung
            // Kontostand des Spielers anpassen
            this.Guthaben -= einsatz;
            
            dreiMalWuerfeln();
            int gewinn = gewinnErmitteln(gluecksZahl, einsatz);

            this.Guthaben += gewinn;

            //if (gluecksZahl == wuerfelZahlen[0] || gluecksZahl == wuerfelZahlen[1] || gluecksZahl == wuerfelZahlen[2])
            //{
            //    gewinn += einsatz;
            //}

            //euer Code

            //for (int j = 0; j < 3; j++)
            //{
            //    if (gluecksZahl == wuerfelZahlen[j])
            //    {
            //        gewinn += einsatz;
            //    }
            //}

            return gewinn;

        }

        

        private int gewinnErmitteln(int gluecksZahl, int einsatz)
        {
            int gewinn = 0;

            foreach (int w in Wuerfelergebnis)
            {
                if (w == gluecksZahl)
                {
                    gewinn += einsatz;
                }
            }

            if (gewinn > 0)
            {
                // wir haben mind. 1 Zahl erraten
                gewinn += einsatz;
            }

            return gewinn;
        }

        private void dreiMalWuerfeln()
        {
            for (int i = 0; i < 3; i++)
            {
                Wuerfelergebnis[i] = wuerfel.wuerfeln();
            }
        }

        public int gewinnChance(int einsatz)
        {
            return einsatz + 3 * einsatz;
        }
    }
}
