using System;

namespace AlgorithmEuclidRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first value: ");
            string inputValue1 = Console.ReadLine();

            Console.Write("Enter second value: ");
            string inputValue2 = Console.ReadLine();

            if (!int.TryParse(inputValue1, out int value1) || !int.TryParse(inputValue2, out int value2))
            {
                Console.WriteLine("You have entered incorrect values.");
                return;
            }
            int divisor = СalculationGCD(value1, value2);
            Console.WriteLine($"{divisor}");
        }

        static int СalculationGCD(int value1, int value2)
        {
            if (value1 == 0)
            {
                return value2;
            }
            if (value2 == 0)
            {
                return value1;
            }
            return СalculationGCD(value2, value1 % value2);
        }
    }
}
