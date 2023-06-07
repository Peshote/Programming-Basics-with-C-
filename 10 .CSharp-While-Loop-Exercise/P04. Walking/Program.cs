using System;

namespace P04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsSum = 0;            
            string input;
            while (stepsSum < 10000)
            {
                input = Console.ReadLine();
                if (input == "Going home")
                {
                    stepsSum += int.Parse(Console.ReadLine());
                    break;
                }
                stepsSum += int.Parse(input);                
            }
            if (stepsSum >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - stepsSum} more steps to reach goal.");
            }
        }
    }
}
