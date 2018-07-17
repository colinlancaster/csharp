using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Single dimensional arrays
            var numbers = new int[5];
            var numbers2 = new int[5] { 1, 2, 3, 4, 5 };

            // Multidimensional array

            // 3 Rows and 5 Columns
            var matrix = new int[3, 5] 
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15}
            };

            // Find the index of a multidimensional array
            var element = matrix[0, 0];

            var colors = new int[3, 5, 4]; // 3 dimensions


            // Jagged array
            var array = new int[3][];

            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];

            array[0][0] = 1;

            // Methods include:
            // Length, Clear(), Copy(), IndexOf(), Reverse(), Sort()


        }
    }
}
