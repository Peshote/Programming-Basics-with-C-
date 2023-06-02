using System;

namespace P09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stayCount = int.Parse(Console.ReadLine());
            string placeKind = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double roomPrice = 18.00;
            double apartmentPrice = 25.00;
            double presidentApartmentPrice = 35.00;
            int nightsCount = stayCount - 1;
            double sumTotal = 0.00;

            if (placeKind == "room for one person")
            {
                sumTotal = roomPrice * nightsCount;
            }
            else if (placeKind == "apartment")
            {
                if (stayCount < 10)
                {
                    sumTotal = apartmentPrice * nightsCount;
                    sumTotal = sumTotal -= sumTotal * 0.30;
                }
                else if (stayCount >= 10 && stayCount <= 15)
                {
                    sumTotal = apartmentPrice * nightsCount;
                    sumTotal = sumTotal -= sumTotal * 0.35;
                }
                else
                {
                    sumTotal = apartmentPrice * nightsCount;
                    sumTotal = sumTotal -= sumTotal * 0.50;
                }
            }
            else
            {
                if (stayCount < 10)
                {
                    sumTotal = presidentApartmentPrice * nightsCount;
                    sumTotal = sumTotal -= sumTotal * 0.10;
                }
                else if (stayCount >= 10 && stayCount <= 15)
                {
                    sumTotal = presidentApartmentPrice * nightsCount;
                    sumTotal = sumTotal -= sumTotal * 0.15;
                }
                else
                {
                    sumTotal = presidentApartmentPrice * nightsCount;
                    sumTotal = sumTotal -= sumTotal * 0.20;
                }
            }
            if (evaluation == "positive")
            {
                sumTotal = sumTotal += sumTotal * 0.25;
            }
            else
            {
                sumTotal = sumTotal -= sumTotal * 0.10;
            }
            Console.WriteLine($"{sumTotal:f2}");
        }
    }
}
