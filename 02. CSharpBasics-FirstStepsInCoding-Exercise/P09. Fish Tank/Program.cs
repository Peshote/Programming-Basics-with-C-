using System;

namespace P09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aquariumLength = int.Parse(Console.ReadLine());
            int aquariumWidth = int.Parse(Console.ReadLine());
            int aquariumHeight = int.Parse(Console.ReadLine());
            double occupiedSpace = double.Parse(Console.ReadLine());
            double occupiedSpacePercent = occupiedSpace / 100;
            int aquariumVolume = aquariumLength * aquariumWidth * aquariumHeight;
            double aquaruiumVolumeLiters = aquariumVolume * 0.001;
            double reqWaterAmount = aquaruiumVolumeLiters * (1 - occupiedSpacePercent);
            Console.WriteLine(reqWaterAmount);
        }
    }
}
