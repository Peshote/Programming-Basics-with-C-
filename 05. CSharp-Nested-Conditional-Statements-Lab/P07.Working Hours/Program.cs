using System;

namespace P07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourTime = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hourTime >= 10 && hourTime <= 18)
            {
                if (day != "Sunday")
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
