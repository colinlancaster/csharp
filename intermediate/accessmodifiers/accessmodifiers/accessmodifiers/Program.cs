using Amazon;

namespace accessmodifiers
{

    class Program
    {
        static void Main(string[] args)
        {
            // Some developers do not like protected classes.
            // It is considered bad practice. If you can avoid it, do.
            // Use private instead.

            // Internal classes are accessible from the same assembly. 

            // Protected internal classes are accessible only from the
            // same assembly or any derived classes. 

            // Lesson = Stick to public or private most of the time.

            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}
