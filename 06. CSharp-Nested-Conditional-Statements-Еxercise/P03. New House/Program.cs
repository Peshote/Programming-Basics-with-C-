using System;

namespace P03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersQuan = int.Parse(Console.ReadLine());
            int budged = int.Parse(Console.ReadLine());
            double rosesPrice = 5.00;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            double narcissusPrice = 3.00;
            double gladiolusPrice = 2.50;
            double totalSum = 0.0;
            double sum;
            if (flowersType == "Roses")
            {
                if (flowersQuan > 80)
                {
                    sum = flowersQuan * rosesPrice;
                    totalSum = sum -= sum * 0.10;
                }
                else
                {
                    totalSum = flowersQuan * rosesPrice;
                }
            }
            else if (flowersType == "Dahlias")
            {
                if (flowersQuan > 90)
                {
                    sum = flowersQuan * dahliasPrice;
                    totalSum = sum -= sum * 0.15;
                }
                else
                {
                    totalSum = flowersQuan * dahliasPrice;
                }
            }
            else if (flowersType == "Tulips")
            {
                if (flowersQuan > 80)
                {
                    sum = flowersQuan * tulipsPrice;
                    totalSum = sum -= sum * 0.15;
                }
                else
                {
                    totalSum = flowersQuan * tulipsPrice;
                }
            }
            else if (flowersType == "Narcissus")
            {
                if (flowersQuan < 120)
                {
                    sum = flowersQuan * narcissusPrice;
                    totalSum = sum += sum * 0.15;
                }
                else
                {
                    totalSum = flowersQuan * narcissusPrice;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                if (flowersQuan < 80)
                {
                    sum = flowersQuan * gladiolusPrice;
                    totalSum = sum += sum * 0.20;
                }
                else
                {
                    totalSum = flowersQuan * gladiolusPrice;
                }
            }
            if (budged >= totalSum)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersQuan} {flowersType} and {budged - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalSum - budged:f2} leva more.");
            }
        }    
    }
}
