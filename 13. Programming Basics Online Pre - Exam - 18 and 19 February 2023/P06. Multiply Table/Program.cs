using System;

namespace P06._Multiply_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string num = input.ToString();
            char char1 = num[0];
            char char2 = num[1];
            char char3 = num[2];
            int num1 = (int)char1 - (int)'0';
            int num2 = (int)char2 - (int)'0';
            int num3 = (int)char3 - (int)'0';


            for(int i = 1; i <= num3; i++)
            {
                for(int j = 1; j <= num2; j++)
                {
                    for(int k = 1; k <= num1; k++)
                    {
                        if(i !=0 && j != 0 && k != 0)
                        {
                            int result = i * j * k;
                            Console.WriteLine($"{i} * {j} * {k} = {result};");
                        }                        
                    }                    
                }
            }
        }
    }
}
