using System;

namespace P04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toyCount = 0;
            int sum1 = 0;
            int sum2 = 0;
            int totalSum = 0;

            for (int i = 0; i <= age; i++)
            {
                if(i % 2 != 0)
                {
                    toyCount += 1;
                }                
            }
            for (int i = 0; i <= age; i++)
            {
                if (i % 2 == 0 && i > 0)
                {
                    sum1 += 1;
                    sum2 = 10;
                    totalSum += sum1 * sum2;
                }                
            }
            totalSum -= sum1;
            totalSum += (toyCount * toyPrice);
            if (totalSum >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {totalSum - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(totalSum - washingMachinePrice):f2}");
            }
        }
    }
}
