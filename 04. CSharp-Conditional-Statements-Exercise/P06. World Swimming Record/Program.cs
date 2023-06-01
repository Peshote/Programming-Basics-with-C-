using System;

namespace P06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double timePerMeter = distance * time;
            double delay = Math.Floor (distance / 15) * 12.5;
            double totalTime = timePerMeter + delay;
            if (totalTime < record)
            {           
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {                
                Console.WriteLine($"No, he failed! He was {Math.Abs(totalTime - record):f2} seconds slower.");
            }
        }
    }
}
