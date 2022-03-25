using System;

namespace _09Primtest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primzahl: Nur durch eine 1 und durch sich selbst teilbar
            //Der Benutzer soll eine Zahö eingeben. Für diese Zahl soll getestet werden, ob es sich um eine Primzahl handelt.
            //Ausgabe auf Konsole: Primzahl Ja/Nein

            Console.Write("Bitte geben Sie Ihre erste Zahl ein: ");
            int a = int.Parse(Console.ReadLine());

            if(a < 2)
            {
                Console.WriteLine("Ihre Zahl ist keie Primzahl");
                return;
            }

            for(int i = 2; i < a / 2; i++)  //Ausreichend wenn wir bis zur hälftew der möglichen Teiler probieren.
            {
                if( a % i == 0)
                {
                    Console.WriteLine("Ihre Zahl ist keine Primzahl");
                    return;
                }
            }
            //Hier haben wir all möglichen Teíler durchprobiert und keine gefunden.
            Console.WriteLine("Ihre Zahl ist eine Primzahl");
        }
    }
}
