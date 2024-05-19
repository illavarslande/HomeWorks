using System;

namespace NextDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сегодняшнюю дату в формате dd mm yyyy.");
            Console.WriteLine("Введите число: ");
            string dayInput = Console.ReadLine();
            Console.WriteLine("Введите месяц: ");
            string monthInput = Console.ReadLine();
            Console.WriteLine("Введите год: ");
            string yearInput = Console.ReadLine();

            if (int.TryParse(dayInput, out int day) && int.TryParse(monthInput, out int month) && int.TryParse(yearInput, out int year))
            {
                if (year >= 0 && month >= 1 && month <= 12)
                {
                    bool leapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                    int daysInMonth;

                    if (month == 2)
                    {
                        daysInMonth = leapYear ? 29 : 28;
                    }
                    else if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        daysInMonth = 30;
                    }
                    else
                    {
                        daysInMonth = 31;
                    }

                    if (day <= 0 || day > daysInMonth)
                    {
                        Console.WriteLine("Вы ввели некоректное значение.");
                    }
                    else
                    {
                        day++;

                        if (day > daysInMonth)
                        {
                            day = 1;
                            month++;

                            if (month > 12)
                            {
                                month = 1;
                                year++;
                            }
                        }

                        Console.WriteLine($"Сдедующая дата: {day}.{month}.{year}!");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некоректное значение.");
                }
            }
            else 
            {
                Console.WriteLine("Вы ввели некоректное значение.");
            }
        }
    }
}
