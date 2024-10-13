using System;

namespace CheckingSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 21, 15, 15, 11, 2, 1 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            if (IsAscendingSort(array))
            {
                Console.WriteLine("The array is sorted in ascending order.");
            }
            else
            {
                Console.WriteLine("The array is not sorted in ascending order.");
            }
           
            if (IsDescendingSort(array))
            {
                Console.WriteLine("The array is sorted in descending order.");
            }
            else
            {
                Console.WriteLine("The array is not sorted in descending order.");
            }
        }

        static bool IsAscendingSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static  bool IsDescendingSort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] > array[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
