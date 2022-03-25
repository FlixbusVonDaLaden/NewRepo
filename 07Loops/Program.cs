using System;
    
namespace _07Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0;

            //for each
            
            foreach (int element in numbers)        //speichere in die Variable element den "aktuellen" Wert
            {
                sum += element;
            }
            Console.WriteLine(sum);

            //for

            for (int i = 0; i < numbers.Length; i++)        //liefere mir einen int (i) bis max numbers.Length und erhöhe dieses i um 1 bei jedem Schleifendurchlauf
            {
                sum += numbers[i];
            }

            sum = 0;
            //while

            int j = 0;      //Zählvariable
            while (j < numbers.Length) 
            {
                sum += numbers[j];
                j++;
            }

            sum = 0;
            //Do-While
            int k = 0;      //Zählvariable
            do
            {
                sum = numbers[k];
                k++;
            } while(k < numbers.Length);
            Console.WriteLine(sum);
           
        }
    }
}
