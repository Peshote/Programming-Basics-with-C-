using System;

namespace P05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pens = 5.80;
            double markers = 7.20;
            double detergent = 1.20;
            int countPens = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            int countDetergent = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double pricePens = pens * countPens;
            double priceMarkers = markers * countMarkers;
            double priceDetergent = detergent * countDetergent;
            double allDiscount = discount / 100;
            double allPrice = pricePens + priceMarkers + priceDetergent;
            double finalPrice = allPrice - (allPrice * allDiscount);
            Console.WriteLine(finalPrice);
        }
    }
}
