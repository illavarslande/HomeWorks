using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 15, 3, 0, -8, 5, 6, 7 };
            Console.WriteLine("Array without sorting:");
            PrintArray(array);
            Console.WriteLine();

            HeapSort(array);
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }

        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }


        static void Heapify(int[] array, int i, int n)
        {
            int child1 = i * 2 + 1;
            int child2 = i * 2 + 2;
            int largest = i;

            if (child1 < n && array[child1] > array[largest])
            {
                largest = child1;
            }
            if (child2 < n && array[child2] > array[largest])
            {
                largest = child2;
            }

            if (i != largest)
            {
                Swap(ref array[i], ref array[largest]);
                Heapify(array, largest, n);
            }
        }

        static void HeapSort(int[] array)
        {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, i, n);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref array[i], ref array[0]);

                Heapify(array, 0, i);
            }
        }
    }
}
