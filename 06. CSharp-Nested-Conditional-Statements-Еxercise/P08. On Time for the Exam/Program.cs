using System;

namespace P08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            examMinute = examMinute + examHour * 60;
            arrivalMinute = arrivalMinute + arrivalHour * 60;

            int timeDifference = examMinute - arrivalMinute;

            if (timeDifference < 0)
            {
                Console.WriteLine("Late");
                if (timeDifference > -60)
                {
                    Console.WriteLine($"{Math.Abs(timeDifference)} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(timeDifference / 60)}:{Math.Abs(timeDifference % 60):D2} hours after the start");
                }
            }
            else if (timeDifference >= 0 && timeDifference <= 30)
            {
                Console.WriteLine("On time");
                if (timeDifference > 0)
                {
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }                
            }
            else
            {
                Console.WriteLine("Early");
                if (timeDifference < 60)
                {
                    Console.WriteLine($"{timeDifference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{timeDifference / 60}:{timeDifference % 60:D2} hours before the start");
                }
            }
        }
    }
}
