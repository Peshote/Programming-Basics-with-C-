using System;

namespace P03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            double musalaGroup = 0;
            double monblanGroup = 0;
            double kilimandjaroGroup = 0;
            double k2Group = 0;
            double everestGroup = 0;

            for (int i = 1; i <= groupCount; i++)
            {
                int personCount = int.Parse(Console.ReadLine());
                if (personCount <= 5)
                {
                    musalaGroup += personCount;
                }
                else if (personCount >= 6 && personCount <= 12)
                {
                    monblanGroup += personCount;
                }
                else if (personCount >= 13 && personCount <= 25)
                {
                    kilimandjaroGroup += personCount;
                }
                else if (personCount >= 26 && personCount <= 40)
                {
                    k2Group += personCount;
                }
                else
                {
                    everestGroup += personCount;
                }
            }
            double totalPersonCount = musalaGroup + monblanGroup + kilimandjaroGroup + k2Group + everestGroup;
            Console.WriteLine($"{musalaGroup / totalPersonCount * 100:f2}%");
            Console.WriteLine($"{monblanGroup / totalPersonCount * 100:f2}%");
            Console.WriteLine($"{kilimandjaroGroup / totalPersonCount * 100:f2}%");
            Console.WriteLine($"{k2Group / totalPersonCount * 100:f2}%");
            Console.WriteLine($"{everestGroup / totalPersonCount * 100:f2}%");
        }
    }
}
