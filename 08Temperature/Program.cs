using System;

namespace _08Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesen sie vom Benutzer 6 Temperaturwerte ( in °C) ein. Benutzen sie dazu eine Schleife
            //Speichern sie die Temperatur in ein array ein
            //Anschließend sollen die Temperaturwerte in K und °F umgerechet werden und auf der Konsole ausgegeben werden

            double[] TempInC = new double[6];
            for(int i = 0; i < TempInC.Length; i++)
            {
                Console.WriteLine("Bitte eine Temperatur in °C eingeben: ");
                TempInC[i] = double.Parse(Console.ReadLine());
            }

            foreach(double temp in TempInC)
            {
                double K = temp + 273.15;
                double F = temp * 9 / 5 + 32;
                Console.WriteLine(temp + "°C; " + K + "K; " + F + "°F");
            }
            
        }
    }
}
