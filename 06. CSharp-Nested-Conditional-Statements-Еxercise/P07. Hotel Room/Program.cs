using System;

namespace P07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int stayCount = int.Parse(Console.ReadLine());
            double studioPrice = 0.00;
            double apartmentPrice = 0.00;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
                if (stayCount > 7 && stayCount <= 14)
                {
                    studioPrice = studioPrice -= studioPrice * 0.05;
                }
                else if (stayCount > 14)
                {
                    studioPrice = studioPrice -= studioPrice * 0.30;
                    apartmentPrice = apartmentPrice -= apartmentPrice * 0.10;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (stayCount > 14)
                {
                    studioPrice = studioPrice -= studioPrice * 0.20;
                    apartmentPrice = apartmentPrice -= apartmentPrice * 0.10;
                }
            }
            else
            {
                studioPrice = 76;
                apartmentPrice = 77;
                if (stayCount > 14)
                {
                    apartmentPrice = apartmentPrice -= apartmentPrice * 0.10;
                }
            }
            Console.WriteLine($"Apartment: {apartmentPrice * stayCount:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice * stayCount:f2} lv.");
        }
    }    
}