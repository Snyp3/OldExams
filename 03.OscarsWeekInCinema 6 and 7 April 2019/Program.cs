using System;

namespace _03.OscarsWeekInCinema_6_and_7_April_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string hallKind = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = 0;


            if (filmName == "A Star Is Born")
            {
                if (hallKind == "normal")
                {
                    ticketPrice = 7.50;
                }
                else if (hallKind == "luxury")
                {
                    ticketPrice = 10.50;
                }
                else if (hallKind == "ultra luxury")
                {
                    ticketPrice = 13.50;
                }
            }
            else if (filmName == "Bohemian Rhapsody")
            {
                if (hallKind == "normal")
                {
                    ticketPrice = 7.35;
                }
                else if (hallKind == "luxury")
                {
                    ticketPrice = 9.45;
                }
                else if (hallKind == "ultra luxury")
                {
                    ticketPrice = 12.75;
                }
            }
            else if (filmName == "Green Book")
            {
                if (hallKind == "normal")
                {
                    ticketPrice = 8.15;
                }
                else if (hallKind == "luxury")
                {
                    ticketPrice = 10.25;
                }
                else if (hallKind == "ultra luxury")
                {
                    ticketPrice = 13.25;
                }
            }
            else if (filmName == "The Favourite")
            {
                if (hallKind == "normal")
                {
                    ticketPrice = 8.75;
                }
                else if (hallKind == "luxury")
                {
                    ticketPrice = 11.55;
                }
                else if (hallKind == "ultra luxury")
                {
                    ticketPrice = 13.95;
                }
            }

            Console.WriteLine($"{filmName} -> {ticketPrice * tickets:f2} lv.");
        }
    }
}
