using System;

namespace Quader
{
    class Program
    {
        static void Main(string[] args)
        {
            Quader q1 = new Quader(1, 2, 3);
            Quader q2 = new Quader(1, 2, 3);

            Console.Write("Die Fläche des Quaders ist: " + q1.Volumen());

        }
    }
}
