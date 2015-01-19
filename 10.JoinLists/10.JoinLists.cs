using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            var line1 = Console.ReadLine().Split(' ');
            List<int> numbers1 = new List<int>();

            foreach (var item in line1)
            {
                numbers1.Add(Convert.ToInt32(item));
            }

            var line2 = Console.ReadLine().Split(' ');

            foreach (var item in line2)
            {
                numbers1.Add(Convert.ToInt32(item));
            }

            var noDupes = numbers1.Distinct().ToList();

            noDupes.Sort();

            foreach (var item in noDupes)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}