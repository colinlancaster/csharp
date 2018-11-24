using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trim() trims away whitespace.
            var fullName = "Colin Lancaster ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper(): '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name Using Split(): " + names[0]);
            Console.WriteLine("Last Name Using Split(): " + names[1]);
            
            Console.WriteLine(fullName.Replace("Colin", "Colin James Lancaster"));

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            // "C" formats in currency. 
            Console.WriteLine(price.ToString("C"));
        }
    }
}
