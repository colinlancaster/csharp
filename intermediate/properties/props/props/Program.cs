using System;

namespace props
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person(new DateTime(1984, 11, 12));

            Console.WriteLine(person.Age);

            Console.ReadLine();

        }
    }
}
