﻿using System;

namespace P04.Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = 2.54;

            double result = a * b;
            Console.WriteLine(result);
        }
    }
}