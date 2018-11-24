using System;
using System.Collections.Generic;

namespace summarizingtext
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a very very very very really really really long sentence.";
            var summary = StringUtility.SummarizeText(sentence, 30);
            Console.WriteLine(summary);
        }

    }
}
