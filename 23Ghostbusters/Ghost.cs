using System;
using System.Collections.Generic;
using System.Text;

namespace _23Ghostbusters
{
    public class Ghost
    {
        protected string name;
        public int Size { get; protected set; }

        public Ghost(string name, int size)
        {
            this.name = name;
            this.Size = size;
        }

        public virtual void haunt()
        {
            Console.WriteLine("Buh...");
        }

        public override string ToString()
        {
            return "Hello, my name is: " + this.name;
        }
    }
}
