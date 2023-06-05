using System;

namespace P06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int juryCount = int.Parse(Console.ReadLine());
            double actorPoints = academyPoints;
            
            for (int i = 1; i <= juryCount && actorPoints <= 1250.5; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());
                int lenght = juryName.Length;
                double finalPoints = ((lenght * juryPoints) / 2);
                actorPoints += finalPoints;
            }
            if (actorPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {actorPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - actorPoints:f1} more!");
            }
        }
    }
}
