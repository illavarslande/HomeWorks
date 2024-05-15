using System;

namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число n: ");

            double fibonacci_1 = 0;
            double fibonacci_2 = 1;
            double numberFibonacci = 0;

            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out double yourNumber))
                {
                    Console.WriteLine("Введите корректное значение.");                
                }
                else
                {
                    for (int i = 2; i <= yourNumber; i++)
                    {
                        numberFibonacci = fibonacci_1 + fibonacci_2;
                        fibonacci_1 = fibonacci_2;
                        fibonacci_2 = numberFibonacci;
                    }
                    Console.WriteLine($"Число Фибоначчи с индексом {yourNumber} - {numberFibonacci}");
                }
            }
        }
    }
}
