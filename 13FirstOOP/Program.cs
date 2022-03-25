using System;

namespace _13FirstOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Felix = new Person("Felix", "Heim", "13.10.2005");
            Person anders = new Person("Anders", "Hejlsberh", "2.12.1960"); //Entwickler der Programmiersprache c#
            Person bjarne = new Person("Bjarme", "Stroustrup", "30.12.1950");  //Entwickler der programmiersprache c++

            Felix.sayHello();       //Objekt hat einen inneren Zustand mit den Argumenten aus dem Konstruktor
            anders.sayHello();
            bjarne.sayHello();
        }
    }
}
