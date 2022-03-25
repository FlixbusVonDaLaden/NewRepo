using System;

namespace _13FirstOOP
{
    public class Person
    {
        //Besteht aus: Datenkomponenten
        private string firstname;       //standardmäßig verwenden wir zu den zugriffsmodifizierte private für datenkomponenten
        private string lastname;
        private string birthday;

        //Konstruktur
        public Person(string firstname, string lastname, string birthday)
        {
            //die klasse initialisieren
            //meistens: die datenkomponenten mit werten der parameter initalisieren
            this.firstname = firstname;  //mit this greife ich auf das aktuelle objekt zu. Ich greife auf die datenkomponente des aktuellen Objektes zu.
                                         //Und ich weise der datenkomponente den wert des parameters zu.
                                         //zufällig heißen datenekomponente und parameter gleich. haben aber NICHTS miteinander zu tun.
            this.lastname = lastname;
            this.birthday = birthday;

            

        }
        //mehtoden

        public void sayHello()
        {
            Console.WriteLine("Hello, I am: " + this.firstname + " " + this.lastname);  //wir greifen hier aud die datenkomponenten firstname und lastname des aktuellen objektes zu.
        }
    }
}
