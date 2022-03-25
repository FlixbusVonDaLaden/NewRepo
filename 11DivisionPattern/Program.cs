using System;

namespace _11DivisionPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //   1 2 3 4 5
            // 1 * * * * *
            // 2 * *   *
            // 3 *   *
            // 4 * *   *
            // 5 *       *

            Console.Write("Bitte geben sie eine einstellige Zahl ein: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

        for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i % j == 0 || j % i == 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine(i);
            }
        }
    }
}
