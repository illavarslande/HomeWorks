using System;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год: ");
            string year = Console.ReadLine();

            if (!int.TryParse(year, out int yearInt))
            {
                Console.WriteLine("Вы ввели буквы.");
            }
            else if (yearInt < 0)
            {
                Console.WriteLine("Вы ввели отрицательное значение.");
            }
            else 
            {
                if ((yearInt % 4 == 0 && yearInt % 100 != 0) || (yearInt % 400 == 0))
                {
                    Console.WriteLine("Этот год високосный!");
                }
                else
                {
                    Console.WriteLine("Этот год не високосный!");
                }
            }
        }
    }
}
