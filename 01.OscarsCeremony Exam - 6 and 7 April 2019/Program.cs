using System;

namespace _01.OscarsCeremony_Exam___6_and_7_April_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double oscars = rent - rent * 0.30;
            double ketering = oscars - oscars * 0.15;
            double surroudSoud = ketering - ketering * 0.50;

            double totalMoneyNeedet = rent + oscars + ketering + surroudSoud;

            Console.WriteLine($"{totalMoneyNeedet:f2}");
        }
    }
}
