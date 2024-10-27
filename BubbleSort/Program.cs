using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 3, 9, 11, 44, 30, 80, 22 };
            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}   ");
            }
            Console.WriteLine();

            for (int i = 0;i < array.Length;i++)
            {
                bool isSort = false;
                for (int j = 0; j < array.Length - (i + 1) ;j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        isSort = true;
                    }
                }
                if (!isSort)
                {
                    break;
                }
            }

            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }
    }
}
