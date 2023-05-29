using System;

namespace P03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());

            double rates = rate/ 100;
            double sum = deposit + months * ((deposit * rates)/12);
            Console.WriteLine(sum);
        }
    }
}