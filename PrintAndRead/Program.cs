using System;

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int value1 = PrintAndRead();
            int value2 = PrintAndRead();
            int value3 = PrintAndRead();

            Console.WriteLine("Sum: " + (value1 + value2 + value3));
        }

        static int PrintAndRead()
        {
            while (true)
            {
                Console.Write("Input value: ");
                string inputValue = Console.ReadLine();
                if (!int.TryParse(inputValue, out int value))
                {
                    Console.WriteLine("Inpur correct int value.");
                }
                else
                {
                    return value;
                    break;
                }
            }
        }
    }
}
