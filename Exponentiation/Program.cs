using System;

namespace Exponentiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number: ");
            string inputBaseNumber = Console.ReadLine();
            if (!int.TryParse(inputBaseNumber, out int baseNumber)) 
            {
                Console.WriteLine("Enter correct number.");
                return;
            }

            Console.WriteLine("Enter the exponent (non-negative): ");
            string inputExponent = Console.ReadLine();
            if (!int.TryParse(inputExponent, out int exponent) || exponent < 0)
            {
                Console.WriteLine("Enter correct exponent.");
                return;
            }
            Console.WriteLine();

            int resultRecursion = PowerRecursion(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {resultRecursion}");
            Console.WriteLine();

            int resultNonRecursion = PowerNonRecursion(baseNumber,exponent);
            Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {resultNonRecursion}");

        }

        static int PowerRecursion(int baseNumber, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }

            return baseNumber * PowerRecursion(baseNumber, exponent - 1);
        }

        static int PowerNonRecursion(int baseNumber, int exponent)
        {
            if (exponent == 0) 
            { 
                return 1; 
            }

            int temp = 1;
            for (int i = 0; i < exponent; i++)
            {
                temp *= baseNumber; 
            }
            return temp;
        }
    }
}

