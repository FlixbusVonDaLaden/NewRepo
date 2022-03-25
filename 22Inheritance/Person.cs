using System;
using System.Collections.Generic;
using System.Text;

namespace _22Inheritance
{
    public class Person //: 
    {
        protected string firstName;
        protected string lastName;
        
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
