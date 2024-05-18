using System;

namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свой возраст (от 1 до 112 лет): ");
            string age = Console.ReadLine();

            if (int.TryParse(age, out int ageInt) && ageInt >= 1 && ageInt <= 112)
            {
                int lastDigit = ageInt % 10;
                int lastTwoDigits = ageInt % 100;

                if (lastTwoDigits != 11 && lastDigit == 1)
                {
                    Console.WriteLine($"Вам {age} год.");
                }
                else if (!(lastTwoDigits >= 12 && lastTwoDigits <= 14) && lastDigit >= 2 && lastDigit <= 4)
                {
                    Console.WriteLine($"Вам {age} года.");
                }
                else
                {
                    Console.WriteLine($"Вам {age} лет.");
                }
            }
            else if (ageInt < 1)
            {
                Console.WriteLine("Вы слишком малы.");
            }
            else
            {
                Console.WriteLine("Вы слишком стары.");
            }
        }
    }
}