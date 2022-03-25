using System;

namespace Uebung3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testprogramm für 3. Test");
            Nutztier rosi = new Ziege("Rosi", 77, 550);
            Console.WriteLine(rosi);
            Console.WriteLine(rosi.lieblingsfutter());


            Ziege linda = new Ziege("Linda", 73, 520);
            Console.WriteLine(linda);
            Console.WriteLine(linda.lieblingsfutter());
            Console.WriteLine("Milchleistung in kg: " + linda.MilchleistungInKg);

        }
    }
}
