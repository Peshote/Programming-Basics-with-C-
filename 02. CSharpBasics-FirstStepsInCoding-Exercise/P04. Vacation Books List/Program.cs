using System;

namespace P04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int allTime = allPages / pagesPerHour;
            int pagesPerDay = allTime / days;
            Console.WriteLine(pagesPerDay);
        }
    }
}
