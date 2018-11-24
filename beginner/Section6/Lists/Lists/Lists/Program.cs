using System;
using System.Collections.Generic;
using System.Data;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists are used when you don't know how many
            // objects you will have in the list. 

            // var numbers = new List<int>();
                                     // Generic types
            // var numbers = new List<int>() { 1, 2, 3, 4 };

            // Available List Methods

            // Add()

            var numbers = new List<int>() { 1, 2, 3, 4 };

            numbers.Add(1);

            // AddRange() adds a new range to the list.
            numbers.AddRange(new int[3] { 5, 6, 7});

            foreach (var number in numbers)
            {
                Console.WriteLine(number); // Produces 1, 2, 3, 4, 1, 5, 6, 7
            }

            // RemoveAt()

            // IndexOf()
            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            // Contains()

            // Count
            Console.WriteLine("Count: " + numbers.Count);
            // Remove()  a single 1
            numbers.Remove(1);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            // In C# you can't modify an enumerable within an iteration.
            //foreach (var number in numbers)
            //{
            //    if (number == 1)
            //    {
            //        numbers.Remove(number);
            //    }
            //}

            // Removes all '1's from the array
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            // Clear()
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}
