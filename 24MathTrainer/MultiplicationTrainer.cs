using System;
using System.Collections.Generic;
using System.Text;

namespace _24MathTrainer
{
    class MultiplicationTrainer : MathTrainer
    {

        public MultiplicationTrainer(int trainingRange)
        {
            Random rand = new Random();
            do
            {
                this.operand1 = rand.Next(trainingRange + 1);
                this.operand2 = rand.Next(trainingRange + 1);
            } while (this.operand1 * this.operand2 );

            
        }


        public override string excercise()
        {
            return this.operand1 + " * " + this.operand2 + " = ";
        }

        public override int getResult()
        {
            return this.operand1 * this.operand2;
        }
    }
}
