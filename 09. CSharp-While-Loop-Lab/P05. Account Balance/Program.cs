using System;

namespace P05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAccount = 0;
            string deposit;

            while ((deposit = Console.ReadLine()) != "NoMoreMoney")
            {
                double depositAmount = double.Parse(deposit);
                if (depositAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                moneyAccount += depositAmount;
                Console.WriteLine($"Increase: {depositAmount:f2}");
            }
            Console.WriteLine($"Total: {moneyAccount:f2}");
        }
    }
}
