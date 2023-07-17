using System;

namespace P04._Grandpa_Stavri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakingDays = int.Parse(Console.ReadLine());
            double rakiaTotalQuan = 0;
            double rakiaTotalDegrees = 0;
            double averageRakiaDegrees = 0;
            for (int i = 0; i < bakingDays; i++)
            {
                double rakiaQuanPerDay = double.Parse(Console.ReadLine());
                double rakiaDegreesPerDay = double.Parse(Console.ReadLine());
                rakiaTotalQuan += rakiaQuanPerDay;
                rakiaTotalDegrees += rakiaDegreesPerDay * rakiaQuanPerDay;
            }
            averageRakiaDegrees = rakiaTotalDegrees / rakiaTotalQuan;

            Console.WriteLine($"Liter: {rakiaTotalQuan:f2}");
            Console.WriteLine($"Degrees: {averageRakiaDegrees:f2}");
            if (averageRakiaDegrees < 38)
            {
                Console.WriteLine($"Not good, you should baking!");
            }
            else if (averageRakiaDegrees >= 38 && averageRakiaDegrees <= 42)
            {
                Console.WriteLine($"Super!");
            }
            else
            {
                Console.WriteLine($"Dilution with distilled water!");
            }
        }
    }
}
