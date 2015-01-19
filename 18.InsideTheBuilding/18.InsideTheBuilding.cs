using System;

namespace InsideTheBuilding
{
    class InsideTheBuilding
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[] x = new int[5];
            int[] y = new int[5];

            for (int i = 0; i < 5; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
                y[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (x[i] >= 0 && x[i] <= size * 3 && y[i] >= 0 && y[i] <= size)
                {
                    Console.WriteLine("inside");
                }
                else if (x[i] >= size && x[i] <= size * 2 && y[i] >= 0 && y[i] <= size * 4)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }
}