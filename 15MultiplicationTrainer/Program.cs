using System;

namespace _15MultiplicationTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
 
            //Console.Write("Bitte geben sie den maximalen Faktor ein: ");
            //int maxFactor = int.Parse(Console.ReadLine());

            //MultiplicationTrainer trainer = new MultiplicationTrainer(maxFactor);
            //trainer.startTraining();

            //Benutzer soll einen Maximalwert der Faktoren auch eingeben können
            //Wir wollen eine einfache Statistik: Prozentwert der richtigen Antworten
            //Am Ende des Trainings soll dieser Wert Ausgegeben werden

            //Erstellen sie eine neue Klasse Divisiontrainer
            //Beachten Sie, dass nur Aufgaben mit ganzahligem Ergebnis erwünscht sind
            Console.WriteLine("Bitte geben sie den minimalen ");

            int maxDiv = 100;
            DivisionTrainer t2 = new DivisionTrainer(maxDiv);
            t2.startTraining();
        }
    }
}
