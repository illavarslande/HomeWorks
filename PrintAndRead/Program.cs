using System;

namespace PrintAndRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers.");

            int value1 = PrintAndRead("Enter 1 value: ");
            int value2 = PrintAndRead("Enter 2 value: ");
            int value3 = PrintAndRead("Enter 3 value: ");

            Console.WriteLine("Sum: " + (value1 + value2 + value3));
        }

        static int PrintAndRead(string enterValues)
        {
            while (true)
            {
                Console.WriteLine(enterValues);

                string inputValue = Console.ReadLine();
                if (!int.TryParse(inputValue, out int value))
                {
                    Console.WriteLine("Inpur correct int value.");
                }
                else
                {
                    return value;
                }
            }
        }
    }
}
