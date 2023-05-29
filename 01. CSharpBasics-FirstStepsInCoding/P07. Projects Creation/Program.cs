using System;

namespace P07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            int hour = 3;
            int projects = project * hour;

            Console.WriteLine($"The architect {name} will need {projects} hours to complete {project} project/s.");
        }
    }
}