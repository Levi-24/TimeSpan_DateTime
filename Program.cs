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
            Console.WriteLine(ts1);
            Console.WriteLine(ts2);
            Console.WriteLine();

            Console.WriteLine(3 * ts1);
            Console.WriteLine(-ts1);
            Console.WriteLine(ts1.Add(ts2));
            Console.WriteLine(ts1.TotalHours);

            //Dátum-idő tárolása
            DateTime dt = new DateTime();
            Console.WriteLine(dt);

        }
    }
}
