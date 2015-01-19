﻿using System;

namespace SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("({0}): ",i+1);
                nums[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(nums);
            Console.WriteLine(new string('=',20));
            Console.WriteLine("Sorted: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("({0}): {1}",i+1,nums[i]);
            }
        }
    }
}
