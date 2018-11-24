using System;
using System.Runtime.InteropServices.ComTypes;

namespace constructors
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer(1, "Colin");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);


        }
    }
}
