using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Colin";
            string lastName = "Lancaster";

            string name = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine("My name is {0}", name); // outputs My Name is Colin Lancaster

            var numbers = new int[3] {1, 2, 3};

            string list = string.Join(", ", numbers); // outputs 1, 2, 3
            Console.WriteLine(list);

            string name2 = "Colin James Lancaster";
            Console.WriteLine(name2[2]);

            // Here are some examples of character escapes
            // \n - New Line
            // \t - Tab
            // \\ - Backslash
            // \' - Single Quotation Mark
            // \" - Double Quotation Mark

            // Look how messy path variables are
            string path = "c:\\projects\\project1\\folder1";

            // Using Verbatim Strings you can clean up paths a lot.
            string path2 = @"c:\projects\project1\folder1";

            var firstName2 =  "Mosh";
            // There is no difference between the above and...
            String lastName3 = "yo";
            // or
            string lastName4 = "mama";

            Console.ReadLine();
        }
    }
}
