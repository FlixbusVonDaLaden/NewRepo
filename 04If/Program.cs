using System;

namespace _04If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie ihre erste Zahl ein: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Bitte geben Sie ihre zweite Zahl ein: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Bitte geben Sie ihre dritte Zahl ein: ");
            int c = int.Parse(Console.ReadLine());

            int min = a;
            int max = a;

            if(b < min)
            {
                min = b;
            }

            if (c < min)
            {
                min = c;
            }

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);



        }
    }
}
