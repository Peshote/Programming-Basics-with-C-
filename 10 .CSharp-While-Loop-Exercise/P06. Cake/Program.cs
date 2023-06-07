using System;

namespace P06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int cakePieces = cakeWidth * cakeLength;
            string input;

            while (cakePieces > 0)
            {
                input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                else
                {
                    cakePieces -= int.Parse(input);
                }
            }
            if (cakePieces > 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
        }
    }
}
