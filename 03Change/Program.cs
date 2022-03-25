using System;

namespace _03Change
{
    class Program
    {
        static void Main(string[] args)
        {
            //Der Benutzer soll einen Geldbertrag eingebejn.
            //Danach soll dieser Geldbetrag in Wechselgeld umgerechnet werden
            //z.B : 71,20
            //123,80
            //0,80
            //99,00

            //double fifty = 50;
            //double twenty = 20;
            //double ten = 10;
            //double five = 5;
            //double two = 2;
            //double one = 1;
            //double half = 0.5;
            //double fifth = 0.2;
            //double tenth = 0.1;


            //    Console.Write("Geben Sie ihren Geldbetrag ein: ");
            //    double Geldbetrag = double.Parse(Console.ReadLine());

            //double fuenfzig = (int)(Geldbetrag / fifty);
            //double zwanzig = (int)((Geldbetrag % fifty) / twenty);
            //double zehner = (int)(((Geldbetrag % fifty) % twenty) / ten);
            //double fuenfer = (int)((((Geldbetrag % fifty) % twenty) % ten) / five);
            //double zweier = (int)(((((Geldbetrag % fifty) % twenty) % ten) % five) / two);
            //double einser = (int)((((((Geldbetrag % fifty) % twenty) % ten) % five) % two) / one);
            //double fuenfzigc = (int)(((((((Geldbetrag % fifty) % twenty) % ten) % five) % two) % one) / half);
            //double zwanzigc = (int)((((((((Geldbetrag % fifty) % twenty) % ten) % five) % two) % one) % half) / fifth);
            //double zehnc = (int)(((((((((Geldbetrag % fifty) % twenty) % ten) % five) % two) % one) % half) % fifth) / tenth);

            //Console.WriteLine("Sie bekommen {0}x fuenfzig Euro", fuenfzig);
            //Console.WriteLine("Sie bekommen {0}x zwanzig Euro", zwanzig);
            //Console.WriteLine("Sie bekommen {0}x zehn Euro", zehner);
            //Console.WriteLine("Sie bekommen {0}x fuenf Euro", fuenfer);
            //Console.WriteLine("Sie bekommen {0}x zwei Euro", zweier);
            //Console.WriteLine("Sie bekommen {0}x einen Euro", einser);
            //Console.WriteLine("Sie bekommen {0}x fuenfzig Cent", fuenfzigc);
            //Console.WriteLine("Sie bekommen {0}x zwanzig Cent", zwanzigc);
            //Console.WriteLine("Sie bekommen {0}x zehn Cent", zehnc);

            Console.Write("Bitte einen Betrag eingeben: ");
            double betrag = double.Parse(Console.ReadLine();

            int anzahl = (int)betrag / 50;
            Console.WriteLine(anzahl + " x 50 Euro");
            double rest = betrag % 50;

            anzahl = (int)rest / 20;
            Console.WriteLine(anzahl + " x 20 Euro");
            rest = rest % 20;

            anzahl = (int)rest / 10;
            Console.WriteLine(anzahl + " x 10 Euro");
            rest = rest % 10;

            anzahl = (int)rest / 5;
            Console.WriteLine(anzahl + " x 5 Euro");
            rest = rest % 5;

            anzahl = (int)rest / 2;
            Console.WriteLine(anzahl + " x 2 Euro");
            rest = rest % 2;

            anzahl = (int)rest / 1;
            Console.WriteLine(anzahl + " x 1 Euro");
            rest = rest % 1;

            anzahl = (int)(rest / 0.5);
            Console.WriteLine(anzahl + " x 0.5 Euro");
            rest = rest % 0.5;

            anzahl = (int)(rest / 0.2);
            Console.WriteLine(anzahl + " x 0.2 Euro");
            rest = rest % 0.2;

            Console.WriteLine(rest + " Trinkgeld");







        }
    }
}
