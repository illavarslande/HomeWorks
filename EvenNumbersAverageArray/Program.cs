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

            int temp = 0;
            double countEven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    temp += array[i];
                    countEven++;
                }
                else
                {
                    continue;
                }
            }
            if (countEven > 0)
            {
                double arrayEvenAverage = temp / countEven;
                Console.WriteLine($"{Math.Round(arrayEvenAverage, 2)}");
            } 
            else 
            {
                Console.WriteLine("Array has not even numbers.");
            }
        }
    }
}