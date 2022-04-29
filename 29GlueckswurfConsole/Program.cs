using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _28Glueckswurf;

namespace _29GlueckswurfConsole
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _28Glueckswurf.Glueckswurf g = new _28Glueckswurf.Glueckswurf(100);
            while (g.Guthaben > 0) {
            }
            Console.WriteLine("Bitte Einsatz eingeben: ");
            int einsatz = int.Parse(Console.ReadLine());
            if (einsatz > g.Guthaben)
            {
                Console.WriteLine("Einsatz ist gr��er als Guthaben!!!");
            }
            else
            {
                Console.Write("Bitte Gl�ckszahl (1-6) eingeben: ");
                int gluecksZahl = int.Parse(Console.ReadLine());
                int gewinn = g.spielen(einsatz, gluecksZahl);
                Console.Write("W�rfelergebnis: ");
                foreach (int zahl in g.Wuerfelergebnis)
                {
                    Console.Write(zahl + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Du hast: " + gewinn + "Euro gewonnen");
                Console.WriteLine("Akktuelles Guthaben: " + g.Guthaben + " Euro");
            }
        }
    }
}
