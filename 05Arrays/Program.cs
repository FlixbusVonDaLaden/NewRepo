using System;

namespace _05Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];   //Container für 5 int, leeres array mit standartinitalisierung mit 0en
            int[] moreNumbers = new int[] { 1, 2, 3, 4 };  // container für 4 int, die bereits mid den werten 1, 2, 3, 4 initialisiert werden
            int[] emptyArray;       //Deklaration für ein array
            emptyArray = new int[2];  //Wertezuweisung eines containers für 2 int, standartisierung mit 0en

            Console.WriteLine(numbers[0]); //Zugriff aud index 0
            Console.WriteLine(moreNumbers[0]);

            numbers[0] = 100;  // Überschreiben eines wertes
            numbers[1] = 200;
            numbers[2] = 300;

            int a = 1;
            Console.WriteLine(numbers[a]);
        }
    }
}
