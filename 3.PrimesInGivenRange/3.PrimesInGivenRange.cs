﻿using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> result = FindPrimesInRange(startNum, endNum);
            for (int i = 0; i < result.Count; i++)
            {
                if (i == result.Count-1)
                {
                    Console.Write("{0}",result[result.Count-1]);
                }
                else
                {
                    Console.Write("{0}, ",result[i]);
                }
            }
            Console.WriteLine();
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> collection = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i)==true)
                {
                    collection.Add(i);
                }
            }
            return collection;
        }

        public static bool IsPrime(int n)
        {
            if (n == 0) return false;
            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
