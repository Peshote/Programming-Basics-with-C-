using System;

namespace P06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spaceWidth = int.Parse(Console.ReadLine());
            int spaceLength = int.Parse(Console.ReadLine());
            int spaceHeight = int.Parse(Console.ReadLine());
            int spaceVolume = spaceWidth * spaceLength * spaceHeight;
            string input;

            while (spaceVolume > 0)
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                else
                {
                    spaceVolume -= int.Parse(input);
                }
            }
            if (spaceVolume > 0)
            {
                Console.WriteLine($"{spaceVolume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(spaceVolume)} Cubic meters more.");
            }
        }
    }
}
