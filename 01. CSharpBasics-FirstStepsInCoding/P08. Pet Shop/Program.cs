using System;

namespace P08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());
            double dogFood = 2.50;
            int catFood = 4;
            double sum = (dog * dogFood + cat * catFood);

            Console.WriteLine($"{sum} lv.");
        }
    }
}