using System;

namespace ydffhgf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eltelt idő tárolása
            TimeSpan ts1 = new TimeSpan(100, 10, 20);
            TimeSpan ts2 = new TimeSpan(03, 30, 22);
            TimeSpan ts3 = TimeSpan.Parse("4.12:10:10.123");

            Console.WriteLine(ts1);
            Console.WriteLine(ts2);
            Console.WriteLine(ts3);
            Console.WriteLine();

            Console.WriteLine(3 * ts1);
            Console.WriteLine(-ts1);
            Console.WriteLine(ts1.Add(ts2));
            Console.WriteLine(ts1.TotalHours);
            Console.WriteLine(ts1.Minutes);
            
            Console.WriteLine();
            //Dátum-idő tárolása
            DateTime dt = new DateTime(1990,10,21);
            Console.WriteLine(dt);

        }
    }
}
