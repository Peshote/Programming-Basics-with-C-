using System;

namespace P05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double changeSum = double.Parse(Console.ReadLine())*100;
            int coinsCounter = 0;
            while (changeSum > 0)
            {
                if (changeSum >= 200)
                {
                    changeSum -= 200;
                }
                else if (changeSum >= 100)
                {
                    changeSum -= 100;
                }
                else if (changeSum >= 50)
                {
                    changeSum -= 50;
                }
                else if (changeSum >= 20)
                {
                    changeSum -= 20;
                }
                else if (changeSum >= 10)
                {
                    changeSum -= 10;
                }
                else if (changeSum >= 5)
                {
                    changeSum -= 5;
                }
                else if (changeSum >= 2)
                {
                    changeSum -= 2;
                }
                else if (changeSum >= 1)
                {
                    changeSum -= 1;
                }
                else
                {
                    changeSum -= 0;
                    break;
                }
                coinsCounter++;
            }
            Console.WriteLine(coinsCounter);
        }
    }
}
