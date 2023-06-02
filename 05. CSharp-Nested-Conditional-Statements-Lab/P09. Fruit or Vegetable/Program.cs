using System;

namespace P09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();

            if (productName == "banana" || productName == "apple" || productName == "kiwi" || productName == "cherry" || productName == "lemon" || productName == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (productName == "tomato" || productName == "cucumber" || productName == "pepper" || productName == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");            
            }
        }
    }
}
