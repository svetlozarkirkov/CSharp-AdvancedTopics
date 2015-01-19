using System;
using System.Collections.Generic;

namespace ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] stringSeparators = new string[] { " ", ". ", ", " };
            string[] text = input.Split(stringSeparators, StringSplitOptions.None);
            List<string> urls = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Contains("http://") || text[i].Contains("www."))
                {
                    urls.Add(text[i]);
                }
            }
            Console.WriteLine();

            foreach (var item in urls)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}