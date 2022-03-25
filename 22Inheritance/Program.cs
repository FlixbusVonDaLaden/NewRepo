using System;

namespace _22Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Max", "Mustermann");
   
            Landwirt l1 = new Landwirt("Thomas", "Riegler", "1734113");
            Person p3 = new Landwirt("Maurice", "Janu", "89234");
            Console.WriteLine(l1.Info);

            Angestellter a1 = new Angestellter("John", "Doe", "123456789");
            Console.WriteLine(a1.Info);

            Person p = a1;  // OK --> weil Ist-Beiehung 
            Person p2 = new Angestellter("Jane", "Doe", "12389");
            p2 = l1;
            p2 = p3;

            // Hta der dynamische Datentyp die aufgerufenen Methode überschrieben, so wird diese aufgerufen
            Console.WriteLine(p2);  // im Hintergund wird automatisch ToString aufgerufen
            //Es wird ToString von der Klasse Landwirt aufgerufen (weil sie dort überschrieben wurde)

            Person p4 = new Angestellter("Peter", "Dammerer", "777888");
            //Statischer Datentyp: Person
            //dynamischer Datenytyp: Angestellter
            Console.WriteLine(p4);
            //Es wrird ToString von der Klasse Person aufgerufen
        }
    }
}
