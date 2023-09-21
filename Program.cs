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
            var dt1 = new DateTime(2023, 09, 01, 22, 00, 00);
            DateTime dt2 = new DateTime(1995,10,11);
            Console.WriteLine(dt1);
            Console.WriteLine(dt1.ToString("yyyy-MM-dd (dddd)"));
            TimeSpan ts4 = dt1 - dt2;
            Console.WriteLine(ts4);

            var dtn = dt1.AddDays(100.5);
            Console.WriteLine(dt1 > dt2);

            var dim = DateTime.DaysInMonth(2012, 07);
            Console.WriteLine(dim);

            var ily = DateTime.IsLeapYear(2000);
            Console.WriteLine(ily);

            var m = DateTime.MaxValue;
            Console.WriteLine(m);

            var dt5 = DateTime.Parse("2000. 04. 16.");
            Console.WriteLine(dt5);
        }
    }
}
