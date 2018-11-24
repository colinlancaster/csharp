using System;

namespace props
{
    public class Person
    {
        // C# creates a private field
        // and auto implements the get and set methods


        // All auto implemented props on top...
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        // Constructors go next...
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        
        // Then calculated properties...
        public int Age
        {
            // Cannot be auto implemented
            // due to the need for logic. 
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;

                return years;
            }
        }
    }
}