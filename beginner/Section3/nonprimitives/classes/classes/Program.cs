﻿using System;
using classes.Math;

namespace classes
{   // ONE CLASS PER FILE!


    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
