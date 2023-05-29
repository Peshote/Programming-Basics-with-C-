using System;

namespace P08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());
            double sneakersPrice = annualFee - (annualFee * 0.40);
            double suitPrice = sneakersPrice - (sneakersPrice * 0.20);
            double basketBallPrice = suitPrice / 4;
            double accessoriesPrice = basketBallPrice / 5;
            double expenses = annualFee + sneakersPrice + suitPrice + basketBallPrice + accessoriesPrice;
            Console.WriteLine(expenses);
        }
    }
}
