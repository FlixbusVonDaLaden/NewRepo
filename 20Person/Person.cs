using System;
using System.Collections.Generic;
using System.Text;

namespace _20Person
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public DateTime Birthday { get; }

        public Person(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                TimeSpan vergangen = DateTime.Now - this.Birthday;
                int years = DateTime.Now.Year - this.Birthday.Year; //Wenn der Geburstag noch nicht dieses Jahr war subtrahieren wir 1 Jahre
                if(now.Month < this.Birthday.Month || now.Month == Birthday.Month && now.Day < this.Birthday.Day)
                {
                    years -= 1;
                }
                
                return years;
            }
        }
    }
}
