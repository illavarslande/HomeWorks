using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число: ");
            string numberInput = Console.ReadLine();

            if (!int.TryParse(numberInput, out int number) || number < 1)
            {
                Console.WriteLine("Вы ввели некорректное значение.");
            }
            else
            {
                Console.Clear();

                Console.Write("    |");
                for (int i = 1; i <= number; i++) 
                {
                    Console.Write($"{i, 4}");
                }
                Console.WriteLine();

                Console.Write("----+");
                for (int i = 1; i <= number; i++)
                {
                    Console.Write("----");
                }
                Console.WriteLine();

                for (int i = 1; i <= number; i++)
                {
                    Console.Write($"{i, 4}|");
                    for (int j = 1; j <= number; j++)
                    {
                        Console.Write($"{i * j, 4}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
