using System;

namespace EvenNumbersAverageArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[random.Next(10)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(20);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            double evenNumbersSum = 0;
            int countEvenNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenNumbersSum += array[i];
                    countEvenNumbers++;
                }
            }

            if (countEvenNumbers > 0)
            {
                double arrayEvenNumbersAverage = evenNumbersSum / countEvenNumbers;
                Console.WriteLine($"{Math.Round(arrayEvenNumbersAverage, 2)}");
            } 
            else 
            {
                Console.WriteLine("Array has not even numbers.");
            }
        }
    }
}