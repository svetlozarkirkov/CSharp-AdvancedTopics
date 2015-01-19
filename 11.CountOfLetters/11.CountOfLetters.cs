using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfLetters
{
    class CountOfLetters
    {
        static void Main()
        {
            string[] letters = Console.ReadLine().Split(' ');
            List<char> alphabet = "abcdefghijklmnopqrstuvwxyz".ToList();
            int count = 0;

            for (int i = 0; i < alphabet.Count; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (letters[j] == Convert.ToString(alphabet[i]))
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine(alphabet[i] + " -> " + count);
                }
                count = 0;
            }
        }
    }
}