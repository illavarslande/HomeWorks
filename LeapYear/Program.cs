using System;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                if (year > 0)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        Console.WriteLine("Этот год високосный!");
                    }
                    else
                    {
                        Console.WriteLine("Этот год не високосный!");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели отрицательное значение.");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели буквы.");
            }
        }
    }
}
