using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fib(n) = {0}",Fib(n));
        }

        public static BigInteger Fib(int n)
        {
            List<BigInteger> fibonacci = new List<BigInteger>();
            fibonacci.Add(1);
            fibonacci.Add(1);
            if (n < 2)
            {
                return fibonacci[n];
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    fibonacci.Add(fibonacci[i - 2] + fibonacci[i - 1]);
                }
                return fibonacci[n];
            }
        }
    }
}
