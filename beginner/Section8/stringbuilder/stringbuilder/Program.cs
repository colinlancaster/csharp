using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Append()
            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace("-", "+")
                .Remove(0, 10);
            //var name = "Mosh";
            //name.ToUpper();
            //Console.WriteLine(name);
            var name = "";
            var result = String.IsNullOrEmpty(name);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
