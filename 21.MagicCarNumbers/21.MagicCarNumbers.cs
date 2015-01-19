using System;

namespace MagicCarNumbers
{
    class MagicCarNumbers
    {
        static void Main()
        {
            int magicWeight = int.Parse(Console.ReadLine());
            char[] letters = new char[10] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
            int[] lettersWeight = new int[10] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        for (int m = 0; m < 10; m++)
                        {
                            for (int n = 0; n < 10; n++)
                            {
                                for (int p = 0; p < 10; p++)
                                {
                                    int tempSum = 40 + i + j + k + m + lettersWeight[n] + lettersWeight[p];

                                    if (tempSum == magicWeight && i != j && j == k && k == m || tempSum == magicWeight && i == j &&
                                        j == k && k == m || tempSum == magicWeight && i == j && j == k && k != m || tempSum == magicWeight &&
                                        i == j && j != k && k == m || tempSum == magicWeight && i == k && j == m && i != j ||
                                        tempSum == magicWeight && i == m && i != j && j == k)
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}