using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {   

            var dateTime = new System.DateTime(2015, 1, 1);
            var now = System.DateTime.Now;
            var today = System.DateTime.Today;

            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Minute:" + now.Minute);
            //Console.ReadLine();

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            // https://www.google.com/search?q=c%23+datetime+format+specifiers&oq=c%23+datetime+format+specifier
        }
    }
}
