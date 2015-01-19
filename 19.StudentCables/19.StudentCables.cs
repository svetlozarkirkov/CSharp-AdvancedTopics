using System;

namespace StudentCables
{
    class StudentCables
    {
        static void Main()
        {
            int cablesCount = int.Parse(Console.ReadLine());
            int[] lengths = new int[cablesCount];
            string[] measures = new string[cablesCount];
            int totalCablesLength = 0;
            int validCables = 0;

            for (int i = 0; i < cablesCount; i++)
            {
                lengths[i] = int.Parse(Console.ReadLine());
                measures[i] = Console.ReadLine();
            }

            for (int i = 0; i < cablesCount; i++)
            {
                if (measures[i] == "meters")
                {
                    totalCablesLength += lengths[i] * 100;
                    validCables++;
                }
                else if (measures[i] == "centimeters" && lengths[i] >= 20)
                {
                    totalCablesLength += lengths[i];
                    validCables++;
                }
            }

            int joinedCable = totalCablesLength - ((validCables - 1) * 3);
            double validStudentCables = joinedCable / 504;

            Console.WriteLine(validStudentCables);
            Console.WriteLine(joinedCable - (validStudentCables * 504));
        }
    }
}