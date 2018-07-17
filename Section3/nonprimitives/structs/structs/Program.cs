using System;

namespace structs
{
    class Program
    {
        // There are some very settle differences between classes and structs.

        // You will use classes 90% of the time, but you may want to use structs for
        // very small things like points on a graph, or the below RgbColor example
        public struct RgbColor
        {
            public int Red;
            public int Green;
            public int Blue;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
