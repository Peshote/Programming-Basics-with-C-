using System;

namespace P05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int l = 1; l <= 9; l++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            if (num % l == 0 && num % j == 0 && num % k == 0 && num % i == 0)
                            {
                                Console.Write($"{l}{j}{k}{i} ");
                            }                            
                        }
                    }            
                }
            }
        }
    }
}
