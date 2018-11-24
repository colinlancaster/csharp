using System;

namespace indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Indexers are a way to access elements in a class
            // that represent a list of values
            var cookie = new HttpCookie();

            cookie["name"] = "Colin";

            Console.WriteLine(cookie["name"]);
            Console.ReadLine();
        }
    }
}
