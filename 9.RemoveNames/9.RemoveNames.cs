using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNames
{
    class RemoveNames
    {
        static void Main()
        {
            var line1 = Console.ReadLine().Split(' ');
            string[] nam1 = line1.Select(d => (d)).ToArray();
            List<string> names1 = new List<string>(nam1);
            var line2 = Console.ReadLine().Split(' ');
            string[] nam2 = line2.Select(d => (d)).ToArray();
            List<string> names2 = new List<string>(nam2);

            for (int i = 0; i < nam1.Length; i++)
            {
                for (int j = 0; j < nam2.Length; j++)
                {
                    if (nam1[i] == nam2[j])
                    {
                        names1[i] = null;
                    }
                }
            }

            foreach (var item in names1)
            {
                if (item != null)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
