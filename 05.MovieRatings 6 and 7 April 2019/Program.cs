using System;

namespace _05.MovieRatings_6_and_7_April_2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filmCount = int.Parse(Console.ReadLine());
            string filmName = string.Empty;
            double filmRating = 0;
            double highRaiting = double.MinValue;
            double lowRaiting = double.MaxValue;
            double averageRating = 0;
            string highFilm = string.Empty;
            string lowFilm = string.Empty;
            

            for (int i = 1; i <= filmCount; i++)
            {
                filmName = Console.ReadLine();
                filmRating = double.Parse(Console.ReadLine());

                if (filmRating > highRaiting)
                {
                    highRaiting = filmRating;
                    highFilm = filmName;
                }
                else if (filmRating < lowRaiting)
                {
                    lowRaiting = filmRating;
                    lowFilm = filmName;
                }

                averageRating += filmRating;
                
            }
            averageRating = averageRating / filmCount;
            Console.WriteLine($"{highFilm} is with highest rating: {highRaiting:f1}");
            Console.WriteLine($"{lowFilm} is with lowest rating: {lowRaiting:f1}");
            Console.WriteLine($"Average rating: {averageRating:f1}");
        }
    }
}
