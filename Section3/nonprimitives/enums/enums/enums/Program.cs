using System;

namespace enums
{
    public enum ShippingMethod
    {   
        // Do not rely on automatic value assignment
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            // An Enum is a set of name/value pairs (constants).

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId); // Returns the Shipping method with the corresponding methodId


            Console.WriteLine(method.ToString());

            var methodName = "Express";

            // Hover over var below. It is type of Shipping Method!. 
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof (ShippingMethod), methodName);
            Console.ReadLine();

        }
    }
}
