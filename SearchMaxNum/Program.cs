using System;

namespace SearchMaxNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] array = new double[random.Next(10)];
            double maxNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10) + random.NextDouble();
                Console.Write(array[i]);
                Console.WriteLine();
            }
            maxNum = SearchMaxNum(array, maxNum);
            Console.WriteLine();
            Console.WriteLine($"The maximum number of this array is {maxNum}.");
        }

        static double SearchMaxNum(double[] array, double maxNum)
        {
            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] > maxNum)
                {
                    maxNum = array[i];
                }
            }
            return maxNum;
        }
    }
}

