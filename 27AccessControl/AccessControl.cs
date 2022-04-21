using System;
using System.Collections.Generic;
using System.Text;

namespace _27AccessControl
{
    public class AccessControl
    {

        public int CurrentCount { get; set; }
        public int MaxCount { get; private set; }

        public AccessControl(int maxCount)
        {
            this.MaxCount = MaxCount;
        }

        public bool canEnter()
        {
            return this.CurrentCount < this.MaxCount;
        }

        public void increment()
        {
            this.CurrentCount++;
        }
        public void decrement()
        {
            this.CurrentCount--;
        }

        public void increment(int count)
        {
            this.CurrentCount += count;
        }

        public void decrement(int count)
        {
            this.CurrentCount -= count;
        }
    }
}
