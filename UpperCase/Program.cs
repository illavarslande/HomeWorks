using System;

namespace UpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Eren", "Armin", "Mikasa" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            array = ToUpperCase(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        static string[] ToUpperCase (string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].ToUpper();
            }
            return array;
        }
    }
}
