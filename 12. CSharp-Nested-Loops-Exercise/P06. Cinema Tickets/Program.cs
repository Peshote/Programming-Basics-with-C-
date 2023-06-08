using System;

namespace P06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int availableSeats;
            string ticketType;
            int totalTickets = 0;
            double studentTickets = 0;
            double standardTickets = 0;
            double kidsTickets = 0;
            int currMovieTickets = 0;
            int takenSeats = 0;
            bool isFinish = false;
            while (movieName != "Finish")
            {
                availableSeats = int.Parse(Console.ReadLine());                
                ticketType = Console.ReadLine();
                while (takenSeats <= availableSeats && ticketType != "End")
                {
                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else
                    {
                        kidsTickets++;
                    }
                    totalTickets++;
                    currMovieTickets++;
                    takenSeats++;
                    if (takenSeats == availableSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                    if (ticketType == "Finish")
                    {
                        isFinish = true;
                        break;
                    }
                }                
                Console.WriteLine($"{movieName} - {currMovieTickets / (double)availableSeats * 100:f2}% full.");
                currMovieTickets= 0;
                takenSeats = 0;
                if (isFinish)
                {
                    break;
                }
                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets / (double)totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTickets / (double)totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidsTickets / (double)totalTickets * 100:f2}% kids tickets.");
        }
    }
}
