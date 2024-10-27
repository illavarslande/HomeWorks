using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 3, 5, 8, 10 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();

            Console.Write("Enter the value to be found in the array: ");
            string inputValue = Console.ReadLine();
            if (!int.TryParse(inputValue, out int value))
            {
                Console.WriteLine("Enter correct value.");
                return;
            }

            int left = 0;
            int right = array.Length - 1;

            int resultWithRecursion = SearchWithRecursion(array, value, left, right);
            Console.WriteLine($"Index of the target value: {resultWithRecursion}");

            int resultWithoutRecursion = SearchWithoutRecursion(array, value);
            Console.WriteLine($"Index of the target value: {resultWithoutRecursion}");
        }

        static int SearchWithRecursion(int[] array, int value, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = left + (right - left) / 2;

            if (array[middle] == value)
            {
                return middle;
            }
            
            if (array[middle] > value) 
            {
                return SearchWithRecursion(array, value, left, middle - 1);
            }

            return SearchWithRecursion(array, value, middle + 1, right);
        }

        static int SearchWithoutRecursion(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (array[middle] == value)
                {
                    return middle; 
                }
                else if (array[middle] > value)
                {
                    right = middle - 1;
                }
                else 
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}
