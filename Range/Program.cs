using System;
using System.Runtime.InteropServices;

namespace Range
{
    class Range
    {
        public int from;
        public int to;

        public int LengthRange()
        {
            return to - from;
        }

        public bool isInside(int num)
        {
            bool result = num < to && num > from;
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Range range = new Range();

            string fromInput = Console.ReadLine();
            if (!int.TryParse(fromInput, out range.from))
            {
                Console.WriteLine("Invalid from number.");
                return;
            }

            string toInput = Console.ReadLine();
            if (!int.TryParse(toInput, out range.to))
            {
                Console.WriteLine("Invalid to number.");
                return;
            }

            int lengthRange = range.LengthRange();
            Console.WriteLine($"LengthRange: {lengthRange}");

            Console.WriteLine("Enter a number: ");
            string numInput = Console.ReadLine();
            if (!int.TryParse(numInput, out int num))
            {
                Console.WriteLine("Invalid number.");
            }
            else
            {
                bool isInside = range.isInside(num);
                Console.WriteLine(isInside);
            }
        }
    }
}
