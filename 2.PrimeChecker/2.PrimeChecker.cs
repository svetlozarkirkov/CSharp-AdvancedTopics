using System;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            Console.Write("n = ");
            UInt64 n = UInt64.Parse(Console.ReadLine());
            Console.WriteLine("IsPrime(n) = {0}",IsPrime(n));
        }

        public static bool IsPrime(UInt64 n)
        {
            if (n == 0) return false;
            if (n == 1) return false;
            if (n == 2) return true;

            for (UInt64 i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
