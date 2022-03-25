using System;
using System.Collections.Generic;
using System.Text;

namespace _24MathTrainer
{
    public class SubtractionTrainer : MathTrainer
    {
        public SubtractionTrainer(int trainingRange)
        {
            Random rand = new Random();
            this.operand1 = rand.Next(trainingRange + 1);
            this.operand2 = rand.Next(trainingRange - operand1);
        }


        public override string excercise()
        {
            return this.operand1 + " - " + this.operand2 + " = ";
        }

        public override int getResult()
        {
            return this.operand1 - this.operand2;
        }
    }
}
