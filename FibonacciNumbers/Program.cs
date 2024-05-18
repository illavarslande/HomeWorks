using System;

namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double number;
            double fibonacci_1 = 0;
            double fibonacci_2 = 1;
            double numberFibonacci = 0;

            while (true)
            {
                Console.WriteLine("Введите целое число n: ");
                string inputNumber = Console.ReadLine();

                if (!double.TryParse(inputNumber, out number))
                {
                    Console.WriteLine("Введите корректное значение.");
                }
                else
                {
                    break;
                }
            }
            for (int i = 2; i <= number; i++)
            {
                numberFibonacci = fibonacci_1 + fibonacci_2;
                fibonacci_1 = fibonacci_2;
                fibonacci_2 = numberFibonacci;
            }
            Console.WriteLine($"Число Фибоначчи с индексом {number} - {numberFibonacci}");
        }
    }
}
