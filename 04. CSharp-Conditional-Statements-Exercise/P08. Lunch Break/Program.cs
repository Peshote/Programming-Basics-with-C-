using System;

namespace P08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int epTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());
            double lunchTime = (double) breakTime * 1 / 8;
            double relaxTime = (double) breakTime * 1 / 4;
            double leftTime = breakTime - lunchTime - relaxTime;
            if (leftTime >= epTime) 
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(leftTime - epTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(epTime - leftTime)} more minutes.");
            }
        }
    }
}
