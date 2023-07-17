using System;

namespace P01._Cat_Diet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double caloriesFats = 9;
            double caloriesProteins = 4;
            double caloriesCarbohydrates = 4;

            double fatsPercent = double.Parse(Console.ReadLine());
            double proteinsPercent = double.Parse(Console.ReadLine());
            double carbohydratesPercent = double.Parse(Console.ReadLine());
            double totalCalories = double.Parse(Console.ReadLine());
            double waterPercent = double.Parse(Console.ReadLine());

            double totalFatsWeight = ((fatsPercent / 100) * totalCalories) / caloriesFats;
            double totalProteinsWeight = ((proteinsPercent / 100) * totalCalories) / caloriesProteins;
            double totalCarbohydratesWeight = ((carbohydratesPercent / 100) * totalCalories) / caloriesCarbohydrates;
            double totalFoodWeight = totalFatsWeight + totalProteinsWeight+ totalCarbohydratesWeight;
            double caloreisPerFoodGram = totalCalories / totalFoodWeight;
            double caloriesPercentWithoutWater = (waterPercent / 100) * caloreisPerFoodGram;
            double finalCalories = caloreisPerFoodGram - caloriesPercentWithoutWater;
            Console.WriteLine($"{finalCalories:f4}");
        }
    }
}
