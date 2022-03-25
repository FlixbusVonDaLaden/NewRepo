using System;
using System.Collections.Generic;
using System.Text;

namespace _14Farmer
{
     public class dog
    {
        private string name;
        private string breed;

        public dog (string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public void bark()
        {
            Console.WriteLine("Wuff" );
        }
        public void saybreed()
        {
            Console.WriteLine("Wuff,....wuff " );
        }

        public string getbreed()
        {
            return this.breed;
        }
        public string getname()
        {
            return this.name;
        }
    }  
}
