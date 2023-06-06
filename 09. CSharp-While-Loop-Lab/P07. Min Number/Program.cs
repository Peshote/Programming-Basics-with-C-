using System;

namespace P06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;
            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);
                if (number < minNum)
                {
                    minNum = number;
                }
            }
            Console.WriteLine(minNum.ToString());
        }
    }
}
