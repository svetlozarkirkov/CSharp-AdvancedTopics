using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestNonDecreasingSubsequence
{
    class LongestNonDecreasingSubsequence
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] nums = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            List<List<int>> sequences = new List<List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    
                }
            }
        }
    }
}
