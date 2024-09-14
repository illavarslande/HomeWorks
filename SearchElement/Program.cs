using System;

namespace SearchElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[6] { 4, 5, 17, 12, 2, 9 };

            Console.Write("Enter a number to search: ");
            string inputTargetNumber = Console.ReadLine();

            if (!int.TryParse(inputTargetNumber, out int targetNumber))
            {
                Console.WriteLine("Inpur correct int value.");
            }
            else
            {
                int index = SearchElement(array, targetNumber);
                Console.WriteLine();
                Console.WriteLine(index);
            }
        }

        static int SearchElement(int[] array, int targetNumber)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == targetNumber)
                {
                    Console.WriteLine("ID of desired number is: ");
                    return i;
                }
            }
            Console.WriteLine("ID of desired number does not exist.");
            return -1;
        }
    }
}
