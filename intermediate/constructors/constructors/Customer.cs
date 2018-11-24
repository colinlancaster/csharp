using System.Collections.Generic;

namespace constructors
{
    partial class Program
    {
        // A constructor is a method that is called when an instance
        // of a class is created. It puts an object in an early state.

        // Constructor have the exact same name as the class.

        public class Customer
        {
            public int Id;
            public string Name;
            // Represents a list of objects.
            // Contained in System.Collections.Generic
            public List<Order> Orders;

            public Customer()
            {
                // If there is a class with a list of objects
                // make sure the list is always initialized
                // in the class, like below.
                Orders = new List<Order>();
            }

            // Constructor declaration
            // To create a constructor very quickly, type 'ctor'
            // and Tab. 
            public Customer(int id)
                // 
                : this()
            {
                // Initialize overload
                this.Id = id;
            }

            public Customer(int id, string name)
            {
                // Initialize overload
                this.Id = id;
                this.Name = name;
            }
        }

    }
}
