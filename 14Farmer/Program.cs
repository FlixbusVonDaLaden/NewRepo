using System;

namespace _14Farmer
{
    class Program
    {
        static void Main(string[] args)
        {
            dog Bella = new dog("Bella", " Berner Sennenhund");
            dog Barkey = new dog("Barkey", "Pudel");
            dog Blacky = new dog("Blacky", "Terrier");


            Bella.bark();
            Barkey.saybreed();
            Blacky.saybreed();

            cats ria = new cats("Ria", "Black");
            cats snowball = new cats("Snowball", "White");
            cats old = new cats("Old", "grey");

            ria.sayName();
            snowball.Saycolour();
            old.Saycolour();

            //Definiere eine Klasse Farmer. Definiere dazu folgende 2 konstruktoren
            //Farmer(string firstname, string lastname)
            //Farmer(string firstname, string lastnma, dog dog, cat cat)
            //Welche datenkomponenten benötigen wir?
            // - firstname
            //-lastname
            // -myCat
            // -mydog
            //Überlege mit welchem Wert mycat und mydag im 1 konstukt initialisiert werden kann!

            Farmer joe = new Farmer("Joe", "Farmer");
            Farmer Rudi = new Farmer("Rudi", "Rüssel", Bella, snowball);
            Farmer mc = new Farmer("Old", "McDonald", Blacky, null); //Es kann auch der wert null für ein Objekt als argument verwendet werden


            string name = Rudi.nameOfdog();
            Console.WriteLine(name);
            name = joe.nameOfdog();
            Console.WriteLine(name);

            string infocat = Rudi.infoOfCat();
            Console.WriteLine(infocat);

            string info = Rudi.info();
            Console.WriteLine(info);
            
            

        }
    }
}
