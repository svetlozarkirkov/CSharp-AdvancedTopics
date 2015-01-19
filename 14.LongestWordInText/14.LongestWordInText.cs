using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestWordInText
{
    class LongestWordInText
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new Char[] { ',', ' ', '.' });
            List<string> words = new List<string>(text);
            Console.WriteLine(words.OrderByDescending(s => s.Length).First());
        }
    }
}
