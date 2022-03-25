using System;
using System.Collections.Generic;
using System.Text;

namespace Test3_01Nutztiere
{
    public class Bueffel : Nutztier
    {

        public Bueffel(string name, int gewicht, int milchleistung) : base(name, gewicht)
        {
            this.MilchleistungInKg = milchleistung;
            Console.WriteLine("Hallo, ich bin " + name + " und ich wiege " + gewichtInKg + " kg.");
        }

        public int MilchleistungInKg
        {
            get
            {
                return this.MilchleistungInKg;
            }
            set
            {
                
            }
        }

        public override string lieblingsfutter()
        {
            return "Mein Lieblingsfutter ist Heu";
        }

     

    } 
    
       
    }
