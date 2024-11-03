using System;

namespace QuickSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 2, -2, 9, 11, 8, 14, 0 };
            Console.WriteLine("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();

            QuickSorting(array, 0, array.Length - 1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }


        }

        static void QuickSorting(int[] array, int left, int right) 
        {
            if (left >= right)
            {
                return;
            }

            int pivot = array[(left + right) / 2];
            int i = left;
            int j = right;

            while (i <= j) 
            {
                while (array[i] < pivot)
                {
                    i++;
                }
                while (array[j] > pivot) 
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }

            }

            if (i < right)
            {
                QuickSorting(array, i, right);
            }

            if (j > left)
            {
                QuickSorting(array, left, j);
            }
        }
    }
}
