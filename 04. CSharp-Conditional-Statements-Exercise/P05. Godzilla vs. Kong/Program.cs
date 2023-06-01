using System;

namespace P05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            int extrasCount = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());
            double decor = budged * 0.10;
            
            if (extrasCount > 150)
            {
                clothingPrice -= clothingPrice * 0.10;
            }
            double expenses = extrasCount * clothingPrice + decor;
            if (expenses > budged)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {expenses - budged:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budged - expenses:f2} leva left.");
            }
        }
    }
}
