using System;

namespace refandvaluetypes
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ***A struct is a _value_ type***

            // VALUE TYPES
            // Allocated on stack
            // Memory allocation done automatically
            // Immediately removed when out of scope. 


            // REFERENCE TYPES
            // You need to allocate memory
            // Memory allocated on heap
            // Memory in heap is a bit more robust. Objects stay longer.
            // They are destroyed when CLR does garbage collection

            // ***A class is a _reference_ type***

            // When you copy an object, there will be two different types.

            // Reference Types

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("a: {0}, b: {1}", a, b); // returns 11

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;

            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
            

            var number = 1;

            Increment(number);
            Console.WriteLine("This is the special number: " + number);

            var person = new Person() {Age = 20}; // It's reference will be copied

            MakeOld(person);
            Console.WriteLine(person.Age);

            var numero = 1;
            var numero2 = numero;
            numero2++;
            Console.WriteLine("The numero is: " + numero);

            Console.ReadLine();
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
