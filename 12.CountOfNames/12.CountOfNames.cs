using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfNames
{
    class CountOfNames
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(' ');
            List<string> namesNew = new List<string>(names);
            namesNew.Sort();
            int count = 1;

            for (int i = 0; i + 1 < namesNew.Count; i++)
            {
                if (namesNew[i] == namesNew[i + 1])
                {
                    count++;
                }
                else if (namesNew[i] != namesNew[i + 1] || i == namesNew.Count - 1)
                {
                    Console.WriteLine(namesNew[i] + " -> " + count);
                    count = 1;
                }
            }
            Console.WriteLine(namesNew.Last() + " -> " + count);
        }
    }
}