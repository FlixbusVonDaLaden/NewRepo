using System;
using System.Collections.Generic;
using System.Text;

namespace _14Farmer
{
     public class Farmer
    {
        private string firstname;
        private string lastname;
        private cats cat;
        private dog dog;


        public Farmer(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.cat = null;                 //diese zeile muss nicht unbedingt geschrieben werden. Erhöht aber die Lesbarkeit
            this.dog = null;
            
        }
        public void sayName()
        {
            Console.WriteLine("My Name is" + this.firstname + " " + this.lastname);

        }
        public Farmer(string firstname, string lastname, dog dog, cats cat)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.cat = cat;
            this.dog = dog;
        }
        public string nameOfdog()
        {
            if(dog != null)               //möglicherweise hat der farmer keinen hund, dann darf auch keine methode von der datenkomponente dog aufgerufen werden
            {
                return this.dog.getname();
            }
            else
            {
                return " ";
            }
            
        }
        public string nameOfCat()
        {
            if (cat != null)
            {
                return cat.getName();
            }
            else
            {
                return " ";
            }
        }
        public string infoOfCat()
        {
            //name und die farbe der Katze zurückgeben
            if(this.cat != null)
            {
                return cat.getcolour() + " " + cat.getName();
            }
            else
            {
                return " ";
            }

        }

        public string infoOfDog()
        {
            //name und die rasse des hundes zurückgeben 
            if(this.dog != null)
            {
                return dog.getbreed() + " " + dog.getname();
            }
            else
            {
                return " ";
            }
        }

        public string info()
        {
            //hier soll Inrofmationen zum farmer zurückgegeben werden
            //vorname und nachname, sowie informationen zu seinen haustieren(nutze die beiden vorigen methoden)
            string result = this.firstname + " " + this.lastname;
            if(this.cat != null)
            {
               result = result + " Cat: " + infoOfCat();

            }
            if(this.dog != null)
            {
                result = result + " Dog: " + infoOfDog();
            }
            return result;
        }

    }
}
