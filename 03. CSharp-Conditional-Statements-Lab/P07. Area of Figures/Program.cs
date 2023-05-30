using System;

namespace P07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shapeType = Console.ReadLine();

            double area = 0;

            if (shapeType == "square") 
            {
                double sideLength = double.Parse(Console.ReadLine());
                area = sideLength * sideLength;                
            }
            else if (shapeType == "rectangle")
            {
                double sideLengthA = double.Parse(Console.ReadLine());
                double sideLengthB = double.Parse(Console.ReadLine());
                area = sideLengthA * sideLengthB;
            }
            else if (shapeType == "circle") 
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (shapeType == "triangle") 
            {
                double sideLength = double.Parse(Console.ReadLine());
                double heightLength = double.Parse(Console.ReadLine());
                area = sideLength * heightLength / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
