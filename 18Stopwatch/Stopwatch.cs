using System;
using System.Collections.Generic;
using System.Text;

namespace _18Stopwatch
{
    public class Stopwatch
    {
        private DateTime start;

        private int maxValue;
        public Stopwatch()
        {
            this.start = DateTime.Now;
        }

        public TimeSpan elapsed()
        {
            return DateTime.Now - this.start;       // Bei Subtraktionen von zwei DateTimes erhalten wir einen  Timespan
        }

        public void reset()
        {
            this.start = DateTime.Now;
        }

        public int RandomNumber()
        {
            maxValue = 10;
            Random r = new Random();               
            int randNumber = r.Next(this.maxValue + 1);      
            int zufzahl = randNumber;
            return randNumber;
        }

       

        
    }


}
