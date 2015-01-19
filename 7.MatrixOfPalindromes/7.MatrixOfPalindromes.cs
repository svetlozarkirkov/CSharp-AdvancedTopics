using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] rowsCols = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            char current = 'a';
            for (int i = 0; i < rowsCols[0]; i++)
            {
                for (int j = 0, k = current; j < rowsCols[1]; j++,k++)
                {
                    Console.Write("{0}{1}{2} ",current,(char)k,current);
                }
                Console.WriteLine();
                current++;
            }
        }
    }
}
