using System;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(1, 100);
            Console.WriteLine(number);
            int attempts = 1;

            Console.Write("Угадайте число от 1 до 100: ");

            while (true)
            {
                string yourNumberInput = Console.ReadLine();

                if (!int.TryParse(yourNumberInput, out int yourNumber) || yourNumber < 1 || yourNumber > 100)
                {
                    Console.WriteLine("Вы ввели некорректные значения.");
                }
                else
                {
                
                    if (number == yourNumber)
                    {
                        Console.WriteLine($"Верно! Количество попыток: {attempts}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Не верно! Попробуйте снова.");
                        attempts++;
                    }
                }
            }
        }
    }
}
