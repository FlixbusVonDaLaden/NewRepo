using System;

namespace _18Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Stopwatch watch = new Stopwatch(); // Zeit beginnt zu laufen
            Console.WriteLine("Ihre Zufallszahl ist "+ watch.RandomNumber()+ " probieren sie so knapp wie möglioch an die Zahl ranzukommen");
            double raza = watch.RandomNumber();
            Console.WriteLine("Bitte eine Taste drücken, um vergange Zeit zu erhalten: ");
            double st = double.Parse(Console.ReadLine()); // Eingegebenen Input ignorieren
            Console.WriteLine(watch.elapsed());

            if(st > raza)
            {
                double abweichung = st - raza;
                Console.WriteLine("Ihre Abweichung ist" + abweichung);
            }





            // Erzeugen sie eine Zufallszahl im Bereich von 1 bis 10 
            // Stellen sie den Benutzer vollgende Aufgabe:
            // Bitte eine Taste nach <Zufallszah> sek drücken
            // Du hast eine Abweichung von <x %> sek zur gestellten Aufgabe


        }
    }
}
