using System;

namespace P09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumM2 = double.Parse(Console.ReadLine());
            double M2 = 7.61;
            double discount = 0.18;
            double sum1 = sumM2 * M2;
            double sum2 = sum1 * discount;
            double endSum = sum1 - sum2;
            Console.WriteLine($"The final price is: {endSum} lv.");
            Console.WriteLine($"The discount is: {sum2} lv.");
        }
    }
}