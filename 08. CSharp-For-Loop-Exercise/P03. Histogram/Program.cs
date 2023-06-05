using System;

namespace P03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers < 200)
                {
                    p1 += 1;
                }
                else if (numbers >= 200 && numbers <400)
                {
                    p2 += 1;
                }
                else if (numbers >= 400 && numbers < 600)
                {
                    p3 += 1;
                }
                else if (numbers >= 600 && numbers < 800)
                {
                    p4 += 1;
                }
                else
                {
                    p5 += 1;
                }
            }
            double numCount = p1 + p2 + p3 + p4 + p5;
            Console.WriteLine($"{p1 / numCount * 100:f2}%");
            Console.WriteLine($"{p2 / numCount * 100:f2}%");
            Console.WriteLine($"{p3 / numCount * 100:f2}%");
            Console.WriteLine($"{p4 / numCount * 100:f2}%");
            Console.WriteLine($"{p5 / numCount * 100:f2}%");
        }
    }
}
