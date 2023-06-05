using System;

namespace P05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabsCount = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            string siteName = "";            
            for (int i = 0; i <= openTabsCount && salary > 0; i++)
            {
                siteName = Console.ReadLine();
                if (siteName == "Facebook")
                {
                    salary -= 150;
                }
                else if (siteName == "Instagram")
                {
                    salary -= 100;
                }
                else if (siteName == "Reddit")
                {
                    salary -= 50;
                }
                else
                {
                    salary -= 0;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}
