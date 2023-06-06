using System;

namespace P08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double annualGrade = 0;
            double totalGrade = 0;
            double finishGrade = 1;
            int exclusion = 0;
            while (finishGrade <= 12)
            {
                annualGrade = double.Parse(Console.ReadLine());
                if (annualGrade >= 4)
                {
                    totalGrade += annualGrade;
                    finishGrade++;
                    if (finishGrade > 12)
                    {
                        finishGrade -= 1;
                        Console.WriteLine($"{studentName} graduated. Average grade: {totalGrade / finishGrade:f2}");
                        break;
                    }
                }
                else if (annualGrade < 4)
                {                    
                    exclusion++;
                    if (exclusion == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {finishGrade} grade");
                        break;
                    }
                }                
            }            
        }
    }
}
