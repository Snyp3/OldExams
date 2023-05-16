using System;

namespace _06.MovieTickets_Exam___15_and_16_June
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Трябва да напишете програма, която чете три цели числа
            //a1, a2, n въведени от потребителя и генерира номера за билети, които се състоят от следните 4 символа:
            //•	Символ 1: символ с ASCII код от а1 до а2 -1
            //•	Символ 2: цифра от 1 до n -1
            //•	Символ 3: цифра от 1 до n / 2 - 1
            //•	Символ 4: цифрова репрезентация(ASCII код) на символ 1
            //След като са изпълнени условията се генерира следния билет:
            //            "{Символ 1}-{Символ 2}{Символ 3}{Символ  4}"


            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());



            for (int i = a1; i < a2; i++)  // Символ 1: символ с ASCII код от а1 до а2 -1
            {
                char symbol1 = (char)i; //Символ 1 в началото е W(ASCII код 87); 

                for (int symbol2 = 1;  symbol2 <=  n - 1; symbol2++)  //•	Символ 2: цифра от 1 до n -1
                {
                    for (int symbol3 = 1; symbol3 <= (n / 2 - 1); symbol3++)  //•	Символ 3: цифра от 1 до n / 2 - 1
                    {
                        if (i % 2 == 1 && (symbol2 + symbol3 + i) % 2 == 1)
                        {
                            Console.WriteLine($"{symbol1}-{symbol2}{symbol3}{i}");
                            // всички билетни номера, на които числовата репрезентация на символ 1 е нечетна
                            // и сборът на символ 2, символ 3 и символ 4 е нечетен.
                        }
                    }
                }
            }

            
        }
    }
}
