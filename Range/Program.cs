using System;
using System.Runtime.InteropServices;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Range range = new Range(7, 8);
            Console.WriteLine($"Range1: {range.from}, {range.to}");

            Range range1 = new Range(6, 10);
            Console.WriteLine($"Range2: {range1.from}, {range1.to}");

            int length = range.Length();
            Console.WriteLine($"Length Range1: {length}");

            Console.WriteLine("Enter a number: ");
            string numInput = Console.ReadLine();
            if (!int.TryParse(numInput, out int num))
            {
                Console.WriteLine("Invalid number.");
            }
            else
            {
                bool isInside = range.IsInside(num);
                Console.WriteLine(isInside);
            }

            Range intersection = range.GetIntersection(range1);
            if (intersection == null)
            {
                Console.WriteLine($"Intersection: {null}");
            }
            else
            {
                Console.WriteLine($"Intersection: [{intersection.from}, {intersection.to}]");
            }

            Range[] getSum = range.GetUnion(range1);
            foreach (var sumRange in getSum)
            {
                Console.WriteLine($"Sum: [{sumRange.from}, {sumRange.to}]");
            }

            Range[] getDifference = range.GetDifference(range1);
            foreach (var differenceRange in getDifference)
            {
                Console.WriteLine($"Difference: [{differenceRange.from}, {differenceRange.to}]");
            }
        }
    }
}
