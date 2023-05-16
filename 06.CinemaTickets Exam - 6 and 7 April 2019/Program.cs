using System;

namespace _06.CinemaTickets_Exam___6_and_7_April_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName;
            int freePlaces;
            int ticketStudent = 0;
            int ticketStandart = 0;
            int ticketKids = 0;
            double placeCount = 0;
            string ticketType = string.Empty;
            double totalTicketSold = 0;

            while ((filmName = Console.ReadLine()) != "Finish")
            {
                freePlaces=int.Parse(Console.ReadLine());
                placeCount = 0;
                for (int i = 1; i <= freePlaces; i++)
                {
                    ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        
                        break;
                        
                    }
                    else if (ticketType == "student")
                    {
                        ticketStudent++;
                        placeCount++;
                        totalTicketSold++;

                    }
                    else if (ticketType == "standard")
                    {
                        ticketStandart++;
                        placeCount++;
                        totalTicketSold++;

                    }
                    else if (ticketType == "kid")
                    {
                        ticketKids++;
                        placeCount++;
                        totalTicketSold++;
                    }   
                }

                Console.WriteLine($"{filmName} - {placeCount / freePlaces * 100:f2}% full.");
              
            }
            Console.WriteLine($"Total tickets: {totalTicketSold}");
            Console.WriteLine($"{ticketStudent / totalTicketSold * 100:f2}% student tickets.");
            Console.WriteLine($"{ticketStandart/ totalTicketSold * 100:f2}% standard tickets.");
            Console.WriteLine($"{ticketKids/ totalTicketSold * 100:f2}% kids tickets.");
        }
    }
}
 