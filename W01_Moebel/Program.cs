using System;

namespace W01_Moebel
{
    class Program
    {
        static void Main(string[] args)
        {
            Kasten kasten1 = new Kasten("FernsehKasteen", 400, 200, 2);
            Kasten kasten2 = new Kasten("SchlafZimmerKasten", 200, 100, 2);

            Tisch tisch1 = new Tisch("Esszimmertisch", 300, 50, 60);
            Tisch tisch2 = new Tisch("Esszimmertisch", 500, 45, 77);

            Einkaufskorb cart = new Einkaufskorb();

            cart.addMoebelestück(kasten1);
            cart.addMoebelestück(kasten2);

            cart.addMoebelestück(tisch1);
            cart.addMoebelestück(tisch2);


            Console.WriteLine("Der Gesamtpreis beträgt: " + cart.getPriceTotal());


            cart.printMoebel();
            cart.getPriceTotal();
        }
    }
}


