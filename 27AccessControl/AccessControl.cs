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
            this.MaxCount = maxCount;
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

        public bool canEnter()
        {
            return this.CurrentCount < this.MaxCount;
        }

        public bool canEnter(int count)
        {
            return this.CurrentCount + count <= this.MaxCount && this.CurrentCount + count >= 0;
        }

        public bool canLeave(int count)
        {
            return this.CurrentCount - count >= 0 && this.CurrentCount - count <= this.MaxCount;
        }


    }
}
