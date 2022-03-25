using System;
using System.Collections.Generic;
using System.Text;

namespace _24MathTrainer
{
    public class DivisionTrainer : MathTrainer
    {
        public DivisionTrainer(int trainingRange)
        {
            Random rand = new Random();
             this.operand1 = rand.Next(trainingRange + 1);
             this.operand2 = rand.Next(1, trainingRange + 1);   //minValue = 1 wegen division durch null



        }


        public override string excercise()
        {
            return this.operand1 + " / " + this.operand2 + " = ";
        }

        public override int getResult()
        {
            return this.operand1 / this.operand2;
        }
    }
}
