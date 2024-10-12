using System;

namespace MultiplicationTableArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the multiplication table range: ");
            string inputTableRange = Console.ReadLine();

            if (!int.TryParse(inputTableRange, out int tableRange) || tableRange < 0)
            {
                Console.WriteLine("Enter the correct table range");
            }
            else
            {
                CreateMultiplicationArray(tableRange);
            }
        }

        static void CreateMultiplicationArray(int tableRange)
        {
            int[,] array = new int[tableRange + 1, tableRange + 1];

            for (int i = 1; i < array.GetLength(0); i++) 
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    array[i,j] = i * j;
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
