using System;
using System.Diagnostics;

namespace P12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double salesVol = double.Parse(Console.ReadLine());
            double commission = 0.00;
            if (town == "Sofia")
            {
                if (salesVol >= 0 && salesVol <= 500)
                {
                    commission = 0.05;
                }
                else if (salesVol > 500 && salesVol <= 1000)
                {
                    commission = 0.07;
                }
                else if (salesVol > 1000 && salesVol <= 10000)
                {
                    commission = 0.08;
                }
                else if (salesVol > 10000)
                {
                    commission = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (salesVol >= 0 && salesVol <= 500)
                {
                    commission = 0.045;
                }
                else if (salesVol > 500 && salesVol <= 1000)
                {
                    commission = 0.075;
                }
                else if (salesVol > 1000 && salesVol <= 10000)
                {
                    commission = 0.10;
                }
                else if (salesVol > 10000)
                {
                    commission = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (salesVol >= 0 && salesVol <= 500)
                {
                    commission = 0.055;
                }
                else if (salesVol > 500 && salesVol <= 1000)
                {
                    commission = 0.08;
                }
                else if (salesVol > 1000 && salesVol <= 10000)
                {
                    commission = 0.12;
                }
                else if (salesVol > 10000)
                {
                    commission = 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            if (commission != 0)
            {
                Console.WriteLine($"{salesVol * commission:f2}");
            }
        }
    }
}