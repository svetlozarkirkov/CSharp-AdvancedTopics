using System;

namespace ProgrammerDNA
{
    class ProgrammerDNA
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char currentChar = char.Parse(Console.ReadLine());
            int tochki = 3;
            int bukvi = 1;

            for (int i = 0, k = 1; i < n; i++)
            {
                Console.Write(new string('.', tochki));
                for (int j = 0; j < bukvi; j++)
                {
                    if (currentChar == 'G')
                    {
                        Console.Write(currentChar);
                        currentChar = 'A';
                    }
                    else
                    {
                        Console.Write(currentChar);
                        currentChar++;
                    }
                }
                Console.Write(new string('.', tochki));
                Console.WriteLine();
                if (k >= 4 && k <= 7)
                {
                    tochki++;
                    bukvi -= 2;
                }
                else
                {
                    tochki--;
                    bukvi += 2;
                }
                if (k == 7)
                {
                    k = 1;
                    tochki = 3;
                    bukvi = 1;
                }
                else
                {
                    k++;
                }
            }
        }
    }
}
