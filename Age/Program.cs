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
                char lastDigit = age[age.Length - 1];
                if (ageInt != 11 && lastDigit == '1' && ageInt != 111)
                {
                    Console.WriteLine($"Вам {age} год.");
                }
                else if (!(ageInt >= 12 && ageInt <= 14) && ageInt != 112 && (lastDigit >= '2' && lastDigit <= '4'))
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