using System;
using System.Reflection.Metadata.Ecma335;

namespace SearchMaxNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] array = new double[random.Next(10)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10) + random.NextDouble();
                Console.Write(array[i]);
                Console.WriteLine();
            }
            double maxNum = SearchMaxNum(array);
            Console.WriteLine();
            Console.WriteLine($"The maximum number of this array is {maxNum}.");
        }

        static double SearchMaxNum(double[] array)
        {
            double maxNum = 0;
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

