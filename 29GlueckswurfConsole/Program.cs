using System;
using _28Glueckswurf;

namespace _29GlueckswurfConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Glueckswurf g = new Glueckswurf(100);
            Console.WriteLine("Aktuelles Guthaben: " + g.Guthaben + " Euro");
            while (g.Guthaben > 0) 
            { 
                Console.Write("Bitte einen Einsatz wählen: ");
                int einsatz = int.Parse(Console.ReadLine());
                if(einsatz > g.Guthaben)
                {
                    Console.WriteLine("Der Einsatz übersteigt das Guthaben!!");
                }
                else
                {
                    Console.Write("Bitte eine Glückszahl eingeben: ");
                    int gluecksZahl = int.Parse(Console.ReadLine());
                    int gewinn = g.spieleEinSpiel(gluecksZahl, einsatz);
                    Console.Write("Würfelergebnis: ");
                    foreach(int zahl in g.Wuerfelergebnis)
                    {
                        Console.Write(zahl + " ");
                    }
                    Console.WriteLine("Du hast " + gewinn + " Euro gewonnen");
                    Console.WriteLine("Aktuelles Guthaben: " + g.Guthaben + " Euro");
                    Console.WriteLine("");
                }
            }

        }
    }
}
