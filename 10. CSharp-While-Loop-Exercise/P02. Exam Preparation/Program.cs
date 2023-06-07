using System;

namespace P02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowScores = int.Parse(Console.ReadLine());
            int lowScoreTimes = 0;
            int finishedTaskCount = 0;
            double scoresSum = 0;
            string lastTask = "";
            bool isFailed = true;
            while (lowScoreTimes < lowScores)
            {
                string taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int score = int.Parse(Console.ReadLine());
                if (score <= 4)
                {
                    lowScoreTimes++;
                }
                scoresSum += score;
                finishedTaskCount++;
                lastTask = taskName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {lowScores} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {scoresSum / finishedTaskCount:f2}");
                Console.WriteLine($"Number of problems: {finishedTaskCount}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
