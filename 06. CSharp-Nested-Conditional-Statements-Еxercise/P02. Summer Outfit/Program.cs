using System;
using System.Text.Unicode;

namespace P02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (temp >= 10 && temp <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temp > 18 && temp <= 24)
            {
                if (timeOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Morning" || timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temp >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temp} degrees, get your {outfit} and {shoes}.");
        }
    }
}
