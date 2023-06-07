using System;

namespace P03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationCost = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (availableMoney < vacationCost && spendingCounter < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (action == "save")
                {
                    availableMoney += money;
                    spendingCounter = 0;
                }
                else
                {
                    availableMoney -= money;                    
                    spendingCounter++;                    
                }
                if (availableMoney < 0)
                {
                    availableMoney = 0;
                }                    
            }
            if (spendingCounter == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (availableMoney >= vacationCost)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
