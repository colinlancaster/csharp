using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace conditionalstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //var hour = 10;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("It's morning!");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("It's afternoon!");
            //}
            //else
            //{
            //    Console.WriteLine("It's evening!");
            //}

            //bool isGoldCustomer = false;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            //Console.ReadLine();
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect outside because it's SUMMER.");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's damp but my flowers are blooming!");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's cold and snowy. A GREAT day for a fire.");
                    break;
                
                default:
                    Console.WriteLine("What the heck! That isn't a season!");
                    break;
            }
        }

    }
}
