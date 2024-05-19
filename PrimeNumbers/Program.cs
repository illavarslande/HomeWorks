using System;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                Console.WriteLine("Введите целое число: ");
                string numberInput = Console.ReadLine();
                if (!int.TryParse(numberInput, out number))
                {
                    Console.WriteLine("Введите корректное значение");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Простые числа от 0 до {number}: ");
            for (int i = 2; i <= number; i++)
            {
                bool isPrimeNumber = true;
                for (int j = 2;  j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
