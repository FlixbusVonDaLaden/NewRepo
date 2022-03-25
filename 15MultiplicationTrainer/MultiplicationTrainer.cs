using System;
using System.Collections.Generic;
using System.Text;

namespace _15MultiplicationTrainer
{
//    class MultiplicationTrainer
//    {
//        private int factor1;
//        private int factor2;
//        private int maxValue;

//        public MultiplicationTrainer(int maxvalue)
//        {
//            this.maxValue = maxvalue;
//            //Die Faktoren lassen wir vorerst uninitialisiert --> Später
//        }

       
//        public string exercise()
//        {
//            Random r = new Random();                     // Erzeugen eines Objekts r von der Klasse Random
//            int randNumber = r.Next(this.maxValue + 1);      // Liefert Zufallszahl < maxValue
//            this.factor1 = randNumber;
//            randNumber = r.Next(this.maxValue + 1);
//            this.factor2 = randNumber;
//            return this.factor1 + " * " + this.factor2 + " = ";
//        }

//        public int getResult()
//        {
//            //In den Datenkomponenten Factor 1 und Factor 2 sind unsere aktuellen Komponenten gespeichert
//            return this.factor1 * factor2;
//        }

//        public void startTraining()
//        {
//            Console.Write("Wie viele Rechnungen (Richtig gelöst) willst du trainieren?");
//            int nrOfExercise = int.Parse(Console.ReadLine());
//            int correctNrOfExercises = 0;
//            int incorrectNrOfExercises = 0;
//            while ( correctNrOfExercises < nrOfExercise)
//            {
//                string ex = this.exercise();
//                Console.Write(ex);
//                int product = int.Parse(Console.ReadLine());
//                if(product == this.getResult())
//                {
//                    //Benutzereingabe und berechnetes Ergebnis stimmen überein
//                    Console.WriteLine("Richtig!");
//                    correctNrOfExercises++;
//                }
//                else
//                {
//                    Console.WriteLine("Leider Falsch!");
//                    // Wir geben dem Benutzer jedoch eine Zweite Chance
//                    Console.Write(ex);
//                    product = int.Parse(Console.ReadLine());
//                    if (product == this.getResult())
//                    {
//                        Console.WriteLine("Richtig!");
//                        correctNrOfExercises++;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Leider falsch! Richtige Antwort: " + this.getResult());
//                        incorrectNrOfExercises++;
//                    }



//                }
//            }
//            double ergebnis = ((double)nrOfExercise / (double)incorrectNrOfExercises + (double)nrOfExercise) * 100;

//            Console.Write("Sie haben " + ergebnis + " % erreicht");
//        }

//    }
}
