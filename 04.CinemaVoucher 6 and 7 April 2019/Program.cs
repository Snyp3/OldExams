using System;
using System.Text;

namespace _04.CinemaVoucher_6_and_7_April_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());

            string input;
            int ticketPrice = 0;
            int ticketsCount = 0;
            int otherProduct = 0;
            int otherProductPrice = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Length > 8)
                {
                    ticketPrice = input[0] + input[1];

                    if (voucher >= ticketPrice)
                    {
                        voucher -= ticketPrice;
                    }
                    else
                    {
                        break;  
                    }
                    ticketsCount++;
                }
                else
                {
                    otherProductPrice = input[0];

                    if (voucher >= otherProductPrice)
                    {
                        voucher -= otherProductPrice;
                    }
                    else
                    {
                        break;
                    }   
                    otherProduct++;
                }
            }

            Console.WriteLine(ticketsCount);
            Console.WriteLine(otherProduct);

        }
    }
}
