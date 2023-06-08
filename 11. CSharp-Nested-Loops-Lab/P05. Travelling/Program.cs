using System;

namespace P05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string destination;
            double minimumBudged;                     

            input = Console.ReadLine();

            while (input != "End")
            {
                destination = input;
                minimumBudged = double.Parse(Console.ReadLine());

                while (minimumBudged > 0)
                {                    
                    minimumBudged -= double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                input = Console.ReadLine();
            }
        }
    }
}
