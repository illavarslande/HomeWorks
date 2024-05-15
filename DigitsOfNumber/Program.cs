using System;

namespace DigitsOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Вы ввели не целое число.");
            }
            else
            {
                int digitsSum = 0;
                int oddDigitsSum = 0;
                int maxDigit = 0;

                while (number != 0)
                {
                    digitsSum += number % 10;

                    int digit = number % 10;
                    if (digit % 2 != 0)
                    {
                        oddDigitsSum += digit;
                    }

                    maxDigit = Math.Max(maxDigit, digit);

                    number /= 10;
                }
                Console.WriteLine($"Сумма цифр числа равна {digitsSum}");
                Console.WriteLine($"Сумма нечётных цифр числа равна {oddDigitsSum}");
                Console.WriteLine($"Максимальная цифра числа {maxDigit}");
            }
        }
    }
}
