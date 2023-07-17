using System;

namespace P03._Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deliveryWeight = double.Parse(Console.ReadLine());
            string serviceType = Console.ReadLine();
            int deliveryDistance = int.Parse(Console.ReadLine());
            double pricePerKm = 0;
            double markup = 0;
            double markupPerKm = 0;
            double finalMarkup = 0;

            if (serviceType == "standard")
            {
                if (deliveryWeight < 1)
                {
                    pricePerKm = 0.03;
                }
                else if (deliveryWeight >= 1 && deliveryWeight < 10)
                {
                    pricePerKm = 0.05;
                }
                else if (deliveryWeight >= 10 && deliveryWeight < 40)
                {
                    pricePerKm = 0.10;
                }
                else if (deliveryWeight >= 40 && deliveryWeight < 90)
                {
                    pricePerKm = 0.15;
                }
                else
                {
                    pricePerKm = 0.20;
                }
            }
            else
            {
                if (deliveryWeight < 1)
                {
                    pricePerKm = 0.03;
                    markup = 0.80 * pricePerKm;
                    markupPerKm = deliveryWeight * markup;
                    finalMarkup = deliveryDistance * markupPerKm;
                }
                else if (deliveryWeight >= 1 && deliveryWeight < 10)
                {
                    pricePerKm = 0.05;
                    markup = 0.40 * pricePerKm;
                    markupPerKm = deliveryWeight * markup;
                    finalMarkup = deliveryDistance * markupPerKm;
                }
                else if (deliveryWeight >= 10 && deliveryWeight < 40)
                {
                    pricePerKm = 0.10;
                    markup = 0.05 * pricePerKm;
                    markupPerKm = deliveryWeight * markup;
                    finalMarkup = deliveryDistance * markupPerKm;
                }
                else if (deliveryWeight >= 40 && deliveryWeight < 90)
                {
                    pricePerKm = 0.15;
                    markup = 0.02 * pricePerKm;
                    markupPerKm = deliveryWeight * markup;
                    finalMarkup = deliveryDistance * markupPerKm;
                }
                else
                {
                    pricePerKm = 0.20;
                    markup = 0.01 * pricePerKm;
                    markupPerKm = deliveryWeight * markup;
                    finalMarkup = deliveryDistance * markupPerKm;
                }
            }
            Console.WriteLine($"The delivery of your shipment with weight of {deliveryWeight:f3} kg. would cost {deliveryDistance * pricePerKm + finalMarkup:f2} lv.");
        }
    }
}
