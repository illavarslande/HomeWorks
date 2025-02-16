using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 15, 3, 0, -8, 5, 6, 7 };
            Console.WriteLine("Array without sorting:");
            string arrayStr = string.Join(",", array);
            Console.WriteLine(arrayStr);

            HeapSort(array);
            arrayStr = string.Join(",", array);
            Console.WriteLine("Sorted array:");
            Console.WriteLine(arrayStr);
        }


        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }


        static void Heapify(int[] array, int rootIndex, int arrayLength)
        {
            int child1 = rootIndex * 2 + 1;
            int child2 = rootIndex * 2 + 2;
            int largest = rootIndex;

            if (child1 < arrayLength && array[child1] > array[largest])
            {
                largest = child1;
            }
            if (child2 < arrayLength && array[child2] > array[largest])
            {
                largest = child2;
            }

            if (rootIndex != largest)
            {
                Swap(ref array[rootIndex], ref array[largest]);
                Heapify(array, largest, arrayLength);
            }
        }

        static void HeapSort(int[] array)
        {
            int arrayLength = array.Length;
            for (int lastIndex = arrayLength / 2 - 1; lastIndex >= 0; lastIndex--)
            {
                Heapify(array, lastIndex, arrayLength);
            }

            for (int lastIndex = arrayLength - 1; lastIndex >= 0; lastIndex--)
            {
                Swap(ref array[lastIndex], ref array[0]);

                Heapify(array, 0, lastIndex);
            }
        }
    }
}
