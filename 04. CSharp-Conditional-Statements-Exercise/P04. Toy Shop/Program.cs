using System;

namespace P04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesQuan = int.Parse(Console.ReadLine());
            int dollsQuan = int.Parse(Console.ReadLine());
            int bearsQuan = int.Parse(Console.ReadLine());
            int minionsQuan = int.Parse(Console.ReadLine());
            int trucksQuan = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPrice = 3.00;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;

            int toysQuan = puzzlesQuan + dollsQuan + bearsQuan + minionsQuan + trucksQuan;
            double toysSum = puzzlePrice * puzzlesQuan + dollPrice * dollsQuan + bearPrice * bearsQuan + minionPrice * minionsQuan + truckPrice * trucksQuan;


            if (toysQuan >= 50)
            {
                toysSum = toysSum -= toysSum * 0.25;
            }
            double profit = toysSum -= toysSum * 0.10;
            if (profit >= tripPrice)
            {
                Console.WriteLine($"Yes! {profit - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - profit:f2} lv needed.");
            }
        }
    }
}
