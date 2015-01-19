using System;

namespace BitFlipper
{
    class BitFlipper
    {
        static void Main()
        {
            UInt64 n = UInt64.Parse(Console.ReadLine());
            string binary = Convert.ToString((long)n, 2).PadLeft(64, '0');
            char[] collected = new char[64];

            for (int i = 0; i < binary.Length; )
            {
                if (i <= 61)
                {
                    if (binary[i] == binary[i + 1] && binary[i + 1] == binary[i + 2])
                    {
                        if (binary[i] == '0')
                        {
                            collected[i] = '1';
                            collected[i + 1] = '1';
                            collected[i + 2] = '1';
                            i += 3;
                        }
                        else if (binary[i] == '1')
                        {
                            collected[i] = '0';
                            collected[i + 1] = '0';
                            collected[i + 2] = '0';
                            i += 3;
                        }
                    }
                    else
                    {
                        collected[i] = binary[i];
                        i++;
                    }
                }
                else
                {
                    collected[i] = binary[i];
                    i++;
                }

            }
            string joined = string.Join("", collected);
            Console.WriteLine(Convert.ToUInt64(joined, 2));
        }
    }
}