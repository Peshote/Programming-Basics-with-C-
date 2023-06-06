using System;

namespace P06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            Console.WriteLine(maxNum.ToString());
        }
    }
}
