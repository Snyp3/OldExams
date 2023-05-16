using System;

namespace _02.GodzillaVs.Kong_Exam___6_and_7_April_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetFilm = double.Parse(Console.ReadLine());   
            int statists = int.Parse(Console.ReadLine());
            double statistDress = double.Parse(Console.ReadLine());

            double decor = budgetFilm * 0.10;
             
            if (statists > 150)
            {
                statistDress -= statistDress * 0.1;
            }

            double totalNeedet = (statists * statistDress) + decor;

            if (totalNeedet > budgetFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalNeedet - budgetFilm:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budgetFilm - totalNeedet:f2} leva left.");
            }
           
        }
    }
}
