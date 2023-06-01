using System;

namespace P07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            int vgaCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());
            double vgaPrice = 250;
            double vgaSum = vgaCount * vgaPrice;
            double cpuPrice = vgaSum * 0.35;
            double cpuSum = cpuPrice * cpuCount;
            double ramPrice = vgaSum * 0.10;
            double ramSum = ramPrice * ramCount;
            double totalSum = vgaSum + cpuSum + ramSum;
            if (vgaCount > cpuCount)
            {
                totalSum -= totalSum * 0.15;
            }
            if (budged >= totalSum)
            {
                Console.WriteLine($"You have {budged - totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budged:f2} leva more!");
            }
        }
    }
}
