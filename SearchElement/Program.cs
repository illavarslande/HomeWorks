using System;

namespace SearchElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[random.Next(10)];

            Console.Write("Enter a number to search (from 0 to 20): ");
            string inputNumberDesire = Console.ReadLine();
            if (!int.TryParse(inputNumberDesire, out int numberDesire))
                {
                Console.WriteLine("Inpur correct int value.");
                }
            else 
            {

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(20);
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine(SearchElement(array, numberDesire));
            }
        }

        static int SearchElement(int[] array, int numberDesire)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] == numberDesire)
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
