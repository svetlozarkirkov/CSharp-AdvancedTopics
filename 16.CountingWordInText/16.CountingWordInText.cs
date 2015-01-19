using System;
using System.Text.RegularExpressions;

namespace CountingWordInText
{
    class CountingWordInText
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] separated = Regex.Split(text, @"[^\w\n]");
            int count = 0;

            for (int i = 0; i < separated.Length; i++)
            {
                if (separated[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
            Console.WriteLine();
        }
    }
}