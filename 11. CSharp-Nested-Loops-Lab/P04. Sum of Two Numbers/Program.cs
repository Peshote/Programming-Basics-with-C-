using System;

namespace P04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool flag = false;

            for (int x1 = start; x1 <= stop; x1++)
            {
                for (int x2 = start; x2 <= stop; x2++)
                {
                    combinations++;
                    int result = x1 + x2;
                    if (result == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({x1} + {x2} = {magicNumber})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
