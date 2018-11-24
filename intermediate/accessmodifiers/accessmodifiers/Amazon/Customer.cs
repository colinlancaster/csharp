using System;

// MUST update namespace
namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0)
            //{
            //    Console.WriteLine("Promoted to Level 1!");
            //}
            //else
            //{
            //    Console.WriteLine("Promoted to Level 2!");
            //}
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed!");
        }

        // Overload doesn't matter. Just an example.
        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}