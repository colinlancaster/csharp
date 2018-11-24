using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // What is an array
            // A data structure where you store variables of the same type

            //int number1;
            //int number2;
            //int number3;

            // Arrays have a fixed, immutable size in C#
            // You also must use `new` in order to create size in memory. 

            // Declare an array and Initialize an array
            //int[] numbers = new int[3];

            //// Access array elements
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            // Or you can declare variables during declaration...
            // int[] numbers = new int[3] {1, 2, 3};

            int[] numbers = new int[3];
            numbers[0] = 1;
            // You can also skip the bullshit and just declare a var...
            // var numbers = new int[3];

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);


            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Jack", "John", "Mary"};
            Console.WriteLine(names);
            Console.ReadLine();
        }
    }
}
