using System;

namespace P05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quan = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee")
                    Console.WriteLine(quan * 0.50);
                else if (product == "water")
                    Console.WriteLine(quan * 0.80);
                else if (product == "beer")
                    Console.WriteLine(quan * 1.20);
                else if (product == "sweets")
                    Console.WriteLine(quan * 1.45);
                else if (product == "peanuts")
                    Console.WriteLine(quan * 1.60);
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                    Console.WriteLine(quan * 0.40);
                else if (product == "water")
                    Console.WriteLine(quan * 0.70);
                else if (product == "beer")
                    Console.WriteLine(quan * 1.15);
                else if (product == "sweets")
                    Console.WriteLine(quan * 1.30);
                else if (product == "peanuts")
                    Console.WriteLine(quan * 1.50);
            }
            else if (town == "Varna") 
            {
                if (product == "coffee")
                    Console.WriteLine(quan * 0.45);
                else if (product == "water")
                    Console.WriteLine(quan * 0.70);
                else if (product == "beer")
                    Console.WriteLine(quan * 1.10);
                else if (product == "sweets")
                    Console.WriteLine(quan * 1.35);
                else if (product == "peanuts")
                    Console.WriteLine(quan * 1.55);
            }
        }
    }
}
