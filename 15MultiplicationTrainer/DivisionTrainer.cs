using System;
using System.Collections.Generic;
using System.Text;

namespace _15MultiplicationTrainer
{
    class DivisionTrainer
    {
        private int dividend;
        private int divisor;
        private int maxVal;

        public DivisionTrainer(int maxValue)
        {
            this.maxVal = maxValue;
        }

        public string exercise()
        {
            Random r = new Random(); 
            do
            {
                this.dividend = r.Next(this.maxVal + 1);
                this.divisor = r.Next(1, this.maxVal + 1);
            } while (this.dividend % divisor != 0 || (this.dividend / divisor) > 10 || this.divisor > 10);

            return this.dividend + " / " + this.divisor + " = ";
        }

        public int getResult()
        {
        
            return this.dividend / this.divisor;
        }

        public void startTraining()
        {
            Console.Write("Wie viele Rechnungen (Richtig gelöst) willst du trainieren?");
            int nrOfExercise = int.Parse(Console.ReadLine());
            int correctNrOfExercises = 0;
            int incorrectNrOfExercises = 0;
            while (correctNrOfExercises < nrOfExercise)
            {
                string ex = this.exercise();
                Console.Write(ex);
                int product = int.Parse(Console.ReadLine());
                if (product == this.getResult())
                {
                    //Benutzereingabe und berechnetes Ergebnis stimmen überein
                    Console.WriteLine("Richtig!");
                    correctNrOfExercises++;
                }
                else
                {
                    Console.WriteLine("Leider Falsch!");
                    // Wir geben dem Benutzer jedoch eine Zweite Chance
                    Console.Write(ex);
                    product = int.Parse(Console.ReadLine());
                    if (product == this.getResult())
                    {
                        Console.WriteLine("Richtig!");
                        correctNrOfExercises++;
                    }
                    else
                    {
                        Console.WriteLine("Leider falsch! Richtige Antwort: " + this.getResult());
                        incorrectNrOfExercises++;
                    }



                }
            }



        






        }
    }
}

