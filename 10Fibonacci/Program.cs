using System;

namespace _10Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci Zahlen
            //Fib(0) = 0
            //Fib(1) = 1
            //Fib(2) = Fib(1) + Fib(0) = 1
            //Fib(3) = Fib(1) + Fib(2) = 2
            //Fib(4) = Fib(2) + Fib(3) = 3
            //Fib(5) = FIb(3) + Fib(4) = 5
            //...
            //Fib(10) = 55
            //Fib(34) = 5 702 887

            //Der Benutzer soll eine Zahl einegebn und Sie berechenen die Fibonacci Zahl dieser Zahl eingebenen Zahl

            Console.Write("Bitte geben sie eine Zahl ein: ");
            int nr = int.Parse(Console.ReadLine());

            if(nr == 0)
            {
                Console.WriteLine("Fib(0) = 0");
            }

            else if (nr == 1)
            {
                Console.WriteLine("Fib(1) = 1");
            }

            int fibVVG = 0;
            int fibVG = 1;
            int fib = 0;

            for(int i = 2; i < nr; i++)
            {
                fib = fibVG + fibVVG;
                // Wir bereuen den VG und den VVG für den nächsten schleifendurchlauf vor
                fibVVG = fibVG;
                fibVG = fib;
            }

            Console.WriteLine("FIb(" + nr + ") = " + fib);



        } 
        }
    }
