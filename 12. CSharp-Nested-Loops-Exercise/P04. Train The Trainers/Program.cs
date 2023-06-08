using System;

namespace P04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();            
            double score = 0;
            int scoreCounter = 0;
            double avaragePresentationScore = 0;
            double avaregeFinalScore= 0;


            while (presentationName != "Finish")
            {
                for (int i = 1; i <= juryCount; i++)
                {
                    score = double.Parse(Console.ReadLine());
                    avaragePresentationScore += score;
                    avaregeFinalScore += score;
                    scoreCounter++;
                    if (i == juryCount)
                    {
                        Console.WriteLine($"{presentationName} - {avaragePresentationScore / (double)juryCount:f2}.");
                        avaragePresentationScore = 0;
                    }
                }                
                presentationName = Console.ReadLine();
            }
            if (presentationName == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {avaregeFinalScore / (double)scoreCounter:f2}.");
            }            
        }
    }
}
