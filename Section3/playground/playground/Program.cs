using System;
using System.Dynamic;

namespace playground
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Variables and constants

            //// don't forget to initialize your variables
            //byte number = 2; 

            //int count = 10;
            //// f tells the C# compiler to treat it as a float
            //float totalPrice = 20.95f;
            //// Must use single quotes for chars, otherwise error
            //char character = 'A';
            //// Must use double quotes for strings!
            //string firstName = "Most";
            //bool isWorking = true;


            //// Type 'cw' and Tab twice to expand Console.WriteLine()
            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);
            //Console.ReadLine();

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //const float Pi = 3.14f;

            //byte b = 1;
            //int i = b;

            //float f = 1.0f;

            //int h = (int) f;

            //Console.WriteLine("Here's the int value: " + i);
            //Console.WriteLine("Here's the float value: " + h);
            //Console.ReadLine();

            //int i = 1000;
            // Solve this error by casting
            //byte b = i;

            // Like so...
            //byte b = (byte) i;

            //Console.WriteLine("Check out int: " + b);
            //Console.ReadLine();

            //var number = "12345";

            // The following yields "Cannot convert type string to type int"
            //int i = (int) number;

            // Solve this by using the Convert class
            //int i = Convert.ToInt32(number);

            // But what happens when you try to use a byte...
            //byte b = Convert.ToByte(number); // Error, byte doesn't have enough storage.


            // Let's wrap everything above in a try/catch block. 

            //try
            //{
            //    var number = "12345";
            //    byte b = Convert.ToByte(number);
            //    Console.WriteLine(b);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("The number could not be converted to a byte. ");
            //}

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            Console.ReadLine();
        }
    }
}
