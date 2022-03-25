using System;

namespace _16Reactangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r1 = new Rectangle(10, 20);
            Rectangle r2 = new Rectangle(100, 5);

            Console.WriteLine("Die Fläche von r1 ist: " + r1.area());
            Console.WriteLine("Der Umfang von r1 ist: " + r1.Circumference());

            Console.WriteLine("Die Fläche von r2 ist: " + r2.area());
            Console.WriteLine("Der Umfang von r2 ist: " + r2.Circumference());

            //Verwendung von Properties
            //Zugriff auf den Getter --> Lesender Zugriff
            int x = r1.LenX;
            int y = r1.LenY;
            Console.WriteLine("Rechteck 1: x = " + x + "; y = " + y);

            //Zugriff auf den Setter --> Screibender Zugriff
            r1.LenX = 20;   //Der Wert 20 wird der Variable "Value" zugewiesen
            r1.LenY = 40;

            Console.WriteLine("Die Fläche von r1 ist: " + r1.area());
            Console.WriteLine("Der Umfang von r1 ist: " + r1.Circumference());

            r1.LenX = -10;
            Console.WriteLine("Die Fläche von r1 ist: " + r1.area());
            Console.WriteLine("Der Umfang von r1 ist: " + r1.Circumference());



        }
    }
}
