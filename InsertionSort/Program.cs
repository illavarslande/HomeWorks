using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 6, 5, 9, 11, 2, 0 };

            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                
                while (j >= 0 && temp < array[j])
                {
                    array[j + 1]= array[j];
                    j--;
                }

                array[j + 1] = temp;
            }

            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }
    }
}
