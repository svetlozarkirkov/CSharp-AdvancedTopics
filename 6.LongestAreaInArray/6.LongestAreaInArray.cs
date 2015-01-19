using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            List<string> strings = new List<string>();
            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.ReadLine());
            }
            var result = strings.GroupBy(x => x).Select(x => new
            {
                Name = x.Key,
                Total = x.Count()
            });
            int biggestCount = 0;
            string longestArea = "";
            foreach (var s in result)
            {
                if (s.Total>biggestCount)
                {
                    biggestCount = s.Total;
                    longestArea = s.Name;
                }
            }
            Console.WriteLine(biggestCount);
            for (int i = 0; i < biggestCount; i++)
            {
                Console.WriteLine(longestArea);
            }
        }
    }
}
