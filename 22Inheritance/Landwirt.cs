using System;
using System.Collections.Generic;
using System.Text;

namespace _22Inheritance
{
    public class Landwirt : Person      //wir leiten von der Klasse Person ab
    {
        private string betriebsnummer;

        public Landwirt(string firstName, string lastName, string betriebsnummer) : base(firstName, lastName)
        {
            //base sorgt dafür, dass wir den Konstruktor der Basisklasse aufrufen.
            //Typischerweise sind die Parameter des Konstruktors, die Argumente des Aufrufs des Basisklassenkonstruktors
            this.betriebsnummer = betriebsnummer;
        }

        public string Info
        {
            get
            {
                return this.firstName + " " + this.lastName + " " + this.betriebsnummer;
                //in der abgeleiteten Klasse kann auf protected Datenkomponenten Datenkomponenten der Basisklasse zugegriffen werden.
            }
        }
    }
}
