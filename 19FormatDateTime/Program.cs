using System;

namespace _19FormatDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Now = DateTime.Now;
            Console.WriteLine(Now.ToShortTimeString());
            Console.WriteLine(Now.ToLongDateString());
            Console.WriteLine(Now.ToLongTimeString());
            Console.WriteLine(Now.Year);
            Console.WriteLine(Now.Month);
            Console.WriteLine(Now.DayOfYear);
            Console.WriteLine(Now.Hour);
            Console.WriteLine(Now.Minute);
            Console.WriteLine(Now.Second);
            Console.WriteLine(Now.Millisecond);
            Console.WriteLine(Now.DayOfWeek);

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine("Jahr: " + now.Year);
            DateTime birthday = new DateTime(2005, 10, 13);
            Console.WriteLine("Donnerstag, " + birthday);
            
            TimeSpan vergangen = now - birthday;
            Console.WriteLine(vergangen);
            Console.WriteLine(vergangen.Days);
            Console.WriteLine(vergangen.TotalSeconds);
            
            DateTime Ferien = new DateTime(2022, 7, 2);
            TimeSpan bis = Ferien - now;
            Console.WriteLine(bis.Days);

            DateTime datum6000er = birthday.AddDays(6000);
            Console.WriteLine(datum6000er.ToLongDateString());
            


        }
    }
}
