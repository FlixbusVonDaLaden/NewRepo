using System;
using System.Collections.Generic;
using System.Text;

namespace _22Inheritance
{
    public class Angestellter : Person
    {
        private string personalnummer;

        public Angestellter(string firstName, string lastName, string personalnummer) : base(firstName, lastName)
        {
            
            this.personalnummer = personalnummer;
        }

        public string Info
        {
            get
            {
                return this.firstName + " " + this.lastName + " " + this.personalnummer;
                
            }
        }
    }
}
