using System;

namespace P02._Maiden_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double loveMessagePrice = 0.60;
            double waxRosePrice = 7.20;
            double keyChainPrice = 3.60;
            double caricaturePrice = 18.20;
            double luckySurprisePrice = 22;

            double maidenPartyPrice = double.Parse(Console.ReadLine());
            int loveMessagesQuan = int.Parse(Console.ReadLine());
            int waxRosesQuan = int.Parse(Console.ReadLine());
            int keyChainsQuan = int.Parse(Console.ReadLine());
            int caricaturesQuan = int.Parse(Console.ReadLine());
            int luckySurprisesQuan = int.Parse(Console.ReadLine());

            double orderSum = loveMessagesQuan * loveMessagePrice + waxRosesQuan * waxRosePrice + keyChainsQuan * keyChainPrice + caricaturesQuan * caricaturePrice + luckySurprisesQuan * luckySurprisePrice;
            int orderItemsQuan = loveMessagesQuan + waxRosesQuan + keyChainsQuan + caricaturesQuan + luckySurprisesQuan;

            if (orderItemsQuan >= 25)
            {
                orderSum -= orderSum * 0.35;
            }
            double finalIncome = orderSum -= orderSum * 0.10;
            if (finalIncome >= maidenPartyPrice)
            {
                Console.WriteLine($"Yes! {finalIncome - maidenPartyPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(finalIncome - maidenPartyPrice):f2} lv needed.");
            }
        }   
    }
}
