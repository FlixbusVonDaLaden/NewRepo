using System;
using System.Collections.Generic;
using System.Text;

namespace _14Farmer
{
     public class cats
    {
        private string name;
        private string colour;

        public cats(string name, string colour)
        {
            this.name = name;
            this.colour = colour;
        }

        public void sayName()
        {
            Console.WriteLine("Meow");
        }
        public void Saycolour()
        {
            Console.WriteLine("Meow....Meow" );
        }

        public string getcolour()
        {
            return this.colour;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
