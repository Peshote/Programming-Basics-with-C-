using System;

namespace P08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tourCount = int.Parse(Console.ReadLine());
            int startingRangListPoints = int.Parse(Console.ReadLine());
            int earnedPoints = 0;
            int tourWins = 0;

            for (int i = 1; i <= tourCount; i++)
            {
                string tourStage = Console.ReadLine();
                switch (tourStage)
                {
                    case "W":
                        earnedPoints += 2000;
                        tourWins += 1;
                        break;
                    case "F":
                        earnedPoints += 1200;
                        break;
                    default:
                        earnedPoints += 720;
                        break;
                }
            }
            int finalPoints = startingRangListPoints + earnedPoints;
            int averagePointsPerTour = earnedPoints / tourCount;
            double winPercent = ((double)tourWins / (double)tourCount) * 100;
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePointsPerTour}");
            Console.WriteLine($"{winPercent:f2}%");
        }
    }
}
