using System;

namespace _24MathTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            MathTrainerManager manager = new MathTrainerManager();
            manager.createTraining(10, 100);
            manager.train();
        }
    }
}
