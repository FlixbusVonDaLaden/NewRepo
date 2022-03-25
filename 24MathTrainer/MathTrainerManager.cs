using System;
using System.Collections.Generic;
using System.Text;

namespace _24MathTrainer
{
    public class MathTrainerManager
    {
        private MathTrainer[] excercises;
        private double correctAnswers;

        public MathTrainerManager()
        {
            //Initialisierung der Datenkomponente noch nicht möglich
        }

        public void createTraining(int nrOfExcercises, int trainingRange)
        {
            excercises = new MathTrainer[nrOfExcercises];
            for (int i = 0; i < nrOfExcercises; i++){
                Random rand = new Random();
                int choice = rand.Next(4);
                if (choice == 0)
                {
                    this.excercises[i] = new MultiplicationTrainer(trainingRange);
                }
                if (choice == 1)
                {
                    this.excercises[i] = new MultiplicationTrainer(trainingRange);
                }
                if (choice == 2)
                {
                    this.excercises[i] = new MultiplicationTrainer(trainingRange);
                }
                if (choice == 3)
                {
                    this.excercises[i] = new MultiplicationTrainer(trainingRange);
                }

            }
            correctAnswers = 0;
        }

        public void train()
        {
            for(int i = 0; i < this.excercises.Length; i++)
            {
                MathTrainer trainer = this.excercises[i];
                Console.Write(trainer.excercise());
                //input vom Benutzer
                int result = int.Parse(Console.ReadLine());

                if(result == trainer.getResult())
                {
                    Console.WriteLine("Das Ergebnis ist richtig");
                    this.correctAnswers++;
                }
                else
                {
                    Console.WriteLine("Die Antwort ist falsch probieren sie es nochmal!");
                    Console.WriteLine(trainer.excercise());
                    result = int.Parse(Console.ReadLine());

                    //Überprüfem der 2. Antwort

                    if(result == trainer.getResult())
                    {
                        Console.WriteLine("Die Antwort ist Richtig!");
                        this.correctAnswers += 0.5;
                    }
                    else
                    {
                        //auch beim 2. Versuch falsche Antwort
                        Console.WriteLine("Lieder Flasche Antwort. Die richtige Antwort ist: " + trainer.getResult());
                    }
                }
                
            }
            Console.WriteLine(this.getStatistics());
        }
        public string getStatistics()
        {
            double percent = this.correctAnswers / this.excercises.Length * 100;
            return this.correctAnswers + " / " + this.excercises.Length + ". Das entspricht " + (this.correctAnswers / this.excercises.Length) * 100 + "%";
        }

    }
}
