using System;

namespace P06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            
            if (operation == '+' || operation == '-' || operation == '*')
            {
                int result;
                if (operation == '+')
                {
                    result = num1 + num2;
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                }
                else
                {
                    result = num1 * num2;
                }
                string evenOrOdd = "odd";
                if (result%2 == 0)
                {
                    evenOrOdd = "even";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
            }
            else
            {
                if (operation == '/')
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} {operation} {num2} = {(double)num1 / num2:f2}");
                    }
                }
                else
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} {operation} {num2} = {num1 % num2}");
                    }
                }
            }
                        
        }
    }
}
