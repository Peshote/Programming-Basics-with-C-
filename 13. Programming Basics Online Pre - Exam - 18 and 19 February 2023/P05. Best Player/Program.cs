using System;

namespace P05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string playerName;
            int goalsQuan = 0;
            string bestPlayer = "";
            int bestGoalsScore = 0;
            while (input != "END")
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                playerName = input;
                goalsQuan = int.Parse(Console.ReadLine());
                for (int i = bestGoalsScore; i < goalsQuan; i += goalsQuan)
                {
                    bestPlayer = playerName;
                    bestGoalsScore = goalsQuan;
                }
                if (goalsQuan >= 10)
                {                    
                    break;
                }
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (bestGoalsScore >= 3)
            {
                Console.WriteLine($"He has scored {bestGoalsScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestGoalsScore} goals.");
            }            
        }
    }
}
