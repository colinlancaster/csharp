﻿using System;

namespace TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            var timeSpan = new System.TimeSpan(1, 2, 3);
            var timeSpan1 = new System.TimeSpan(1, 0, 0);
            var timeSpan2 = System.TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: " + duration);

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add

            Console.WriteLine("Add example: " + timeSpan.Add(System.TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(System.TimeSpan.FromMinutes(8)));

            // ToString

            Console.WriteLine("ToString: " + timeSpan.ToString());

            Console.WriteLine("Parse: " + System.TimeSpan.Parse("01:02:03"));
        }
    }
}
