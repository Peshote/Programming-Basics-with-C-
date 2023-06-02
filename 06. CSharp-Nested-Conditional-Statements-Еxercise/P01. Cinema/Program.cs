using System;

namespace P01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rowCount = int.Parse(Console.ReadLine());
            int columnCount = int.Parse(Console.ReadLine());
            double income = 0.0;
            if (projectionType == "Premiere")
            {
                income = rowCount * columnCount * 12.00;
            }
            else if (projectionType == "Normal")
            {
                income = rowCount * columnCount * 7.50;
            }
            else if (projectionType == "Discount")
            {
                income = rowCount * columnCount * 5.00;
            }
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
