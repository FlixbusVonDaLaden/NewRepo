using System;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            long l = i; //Impliziter cast

            short s = (short)i; //expliziter cast

            int j = (int)Math.Pow(2, 30);
            short r = (short)j;     //expliziter cast mit Informationsverlust

            Console.WriteLine(s);
            Console.WriteLine(j);
            Console.WriteLine(r);

            Console.WriteLine("Dies ist ein Probetext");
            string probetext = "Dies ist ein weiterer Text";
            Console.WriteLine(probetext);

            Console.WriteLine("Bitte einen Text eingeben: ");   //Nur write ist kein Zeilenumbruch
            string input = Console.ReadLine();

            Console.Write("Bitte eine Zahl eingeben: ");
            string number = Console.ReadLine();
            int n = int.Parse(number);  //Versuch den String in ein int umzuwandlen

        }
    }
}
