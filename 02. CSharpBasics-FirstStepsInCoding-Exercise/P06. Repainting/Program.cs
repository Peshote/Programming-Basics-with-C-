using System;

namespace P06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceNylon = 1.50;
            double pricePaint = 14.50;
            double priceThinner = 5.00;
            double priceBags = 0.40;
            int countNylon = int.Parse(Console.ReadLine());
            int countPaint = int.Parse(Console.ReadLine());
            int countThinner = int.Parse(Console.ReadLine());
            int countHours = int.Parse(Console.ReadLine());
            double extraPaint = countPaint * 0.10;
            double extraNylon = 2.00;
            double allPrice = ((countNylon + extraNylon) * priceNylon) + ((countPaint + extraPaint) * pricePaint) + (countThinner * priceThinner) + priceBags;
            double workPerHour = countHours * allPrice * 0.30;
            double finalPrice = allPrice + workPerHour;
            Console.WriteLine(finalPrice);
        }
    }
}
