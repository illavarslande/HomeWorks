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
                    int daysInMonth;

                    if (month == 2)
                    {
                        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
                        daysInMonth = isLeapYear ? 29 : 28;
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
                        Console.WriteLine("Вы ввели некорректное значение.");
                    }
                    else
                    {
                        int nextDay = day + 1;
                        int nextMonth = month;
                        int nextYear = year;


                        if (nextDay > daysInMonth)
                        {
                            nextDay = 1;
                            nextMonth = month + 1;

                            if (nextMonth > 12)
                            {
                                nextMonth = 1;
                                nextYear = year + 1;
                            }
                        }
                        Console.WriteLine($"Сдедующая дата: {nextDay}.{nextMonth}.{nextYear}!");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение.");
                }
            }
            else 
            {
                Console.WriteLine("Вы ввели некорректное значение.");
            }
        }
    }
}
