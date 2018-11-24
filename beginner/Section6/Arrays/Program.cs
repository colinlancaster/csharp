using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Single dimensional arrays
            //var numbers = new int[5];
            //var numbers2 = new int[5] { 1, 2, 3, 4, 5 };

            // Multidimensional array

            // 3 Rows and 5 Columns
            //var matrix = new int[3, 5] 
            //{
            //    {1, 2, 3, 4, 5},
            //    {6, 7, 8, 9, 10},
            //    {11, 12, 13, 14, 15}
            //};

            // Find the index of a multidimensional array
            //var element = matrix[0, 0];

            //var colors = new int[3, 5, 4]; // 3 dimensions


            // Jagged array
            //var array = new int[3][];

            //array[0] = new int[4];
            //array[1] = new int[5];
            //array[2] = new int[3];

            //array[0][0] = 1;

            // Methods include:
            // Length, Clear(), Copy(), IndexOf(), Reverse(), Sort()

            var numbers = new[] {3, 7, 9, 2, 14, 6};

            var newNumbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length()
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);

            Console.WriteLine("The index of 9 is " + index);

            // Clear()
            // Starts at 0 and clears the number of elements indicated
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()

            int[] another = new int[3];

            // Copies the first 3 numbers in the numbers array
            // and adds them to the `another` array.
            Array.Copy(numbers, another, 3);
            Console.WriteLine("The effect of Copy()");

            foreach (var n in another)
            {
                Console.WriteLine(n);   
            }

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("The effects of Sort()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(newNumbers);

            Console.WriteLine("The effects of Reverse()");

            foreach (var n in newNumbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
