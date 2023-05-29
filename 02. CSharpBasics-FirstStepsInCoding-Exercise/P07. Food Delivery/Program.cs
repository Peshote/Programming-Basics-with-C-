using System;

namespace P07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegiMenu = 8.15;
            double deliveryCost = 2.50;
            int countChickenMenu = int.Parse(Console.ReadLine());
            int countFishMenu = int.Parse(Console.ReadLine());
            int countVegiMenu = int.Parse(Console.ReadLine());
            double allMenuSum = (chickenMenu * countChickenMenu) + (fishMenu * countFishMenu) + (vegiMenu * countVegiMenu);
            double desertPrice = allMenuSum * 0.20;
            double billSum = allMenuSum + desertPrice + deliveryCost;
            Console.WriteLine(billSum);
        }
    }
}
