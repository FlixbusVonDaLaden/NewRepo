using System;

namespace Erster_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            int[] numbers = new int[3];
            Console.WriteLine("Geben Sie Ihre erste Zahl ein: ");
            numbers[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie Ihre zweite Zahl ein: ");
            numbers[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie Ihre dritte Zahl ein: ");
            numbers[2] = int.Parse(Console.ReadLine());

            int x = numbers[0];
            int y = numbers[1];
            int z = numbers[2];
            

            while(x < 0)
            {
                x = x / 2;
            }
            
            if(x == 1)
            {
                Console.Write("Die Zahl ist gerade");
            }

            if (x <= 1)
            {
                Console.Write("Zahl ist ungerade");
                numbers[0] = 1;
            }


            while (y < 0)
            {
                y = y / 2;
            }

            if (y == 1)
            {
                Console.Write("Die Zahl ist gerade");
            }

            if (y <= 1)
            {
                Console.Write("Zahl ist ungerade");
                numbers[1] = 1;
            }


            while (z < 0)
            {
                z = z / 2;
            }

            if (z == 1)
            {
                Console.Write("Die Zahl ist gerade");
            }

            if (z <= 1)
            {
                Console.Write("Zahl ist ungerade");
                numbers[2] = 1;
            }

            int product = numbers[0] * numbers[1] * numbers[2];
            Console.WriteLine("Das Produkt der eingegebenen Zahlen ist: " + product);









        }
    }
}
