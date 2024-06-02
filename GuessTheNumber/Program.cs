using System;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(1, 100);
            Console.WriteLine(number);
            int attempts = 1;

            Console.Write("Guess the number from 1 to 100: ");

            while (true)
            {
                string yourNumberInput = Console.ReadLine();

                if (!int.TryParse(yourNumberInput, out int yourNumber) || yourNumber < 1 || yourNumber > 100)
                {
                    Console.WriteLine("You have entered incorrect values.");
                }
                else
                {
                
                    if (number < yourNumber)
                    {
                        Console.WriteLine("Wrong! Try again. Your number is less than expected.");
                        attempts++;
                    }
                    else if (number > yourNumber)
                    {
                        Console.WriteLine("Wrong! Try again. Your number is more than expected.");
                        attempts++;
                    }
                    else
                    {
                        Console.WriteLine($"Right! Number of attempts: {attempts}.");
                        break;
                    }
                }
            }
        }
    }
}
