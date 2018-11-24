using System;

namespace classes
{
    class Program
    {

        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine("Hi {0}! I am {1}", to, Name);
            }

            // Static makes it so that you don't have to create
            // a new instance of Person in the Main method
            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;
                return person;
            }
        }

        static void Main(string[] args)
        {
            // Anatomy of a class
            // Data is represented by fields. 
            // Behavior is represented by classes or methods. 

            // Static members are used to represent singleton
            // or things that should only be written once. 
            // Just use the static keyword after the access modifier. 

            //Person person = new Person();
            //      or
            var p = Person.Parse("John");
            //person.Name = "John";
            p.Introduce("Colin");
        }
    }
}
