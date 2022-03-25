using System;

namespace Test3_01Nutztiere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testprogramm für 3. Test");
            Nutztier rosi = new Bueffel("Rosi", 450, 1800);
            Console.WriteLine(rosi);
            Console.WriteLine(rosi.lieblingsfutter());


            Bueffel linda = new Bueffel("Linda", 480, 2100);
            Console.WriteLine(linda);
            Console.WriteLine(linda.lieblingsfutter());
            Console.WriteLine("Milchleistung in kg: " + linda.MilchleistungInKg);


        }
    }
}
