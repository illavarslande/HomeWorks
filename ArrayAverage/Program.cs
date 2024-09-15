using System;

namespace ArrayEvenAverage
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

            int temp = 0;
            double countEven = 0;
            for (int i = 0;i < array.Length;i++)
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
            double arrayEvenAverage = temp / countEven;
            Console.WriteLine($"{Math.Round (arrayEvenAverage, 2)}");
        }
    }
}