using System;

namespace P05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string vacKind = "";
            double sum = 0.0;

            if (budged <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    sum = budged * 0.30;
                    vacKind = "Camp";
                }
                else
                {
                    sum = budged * 0.70;
                    vacKind = "Hotel";
                }
            }
            else if (budged <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    sum = budged * 0.40;
                    vacKind = "Camp";
                }
                else
                {
                    sum = budged * 0.80;
                    vacKind = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                sum = budged * 0.90;
                vacKind = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacKind} - {sum:f2}");
        }
    }
}
