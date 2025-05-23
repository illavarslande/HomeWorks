﻿using System;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Range range = new Range(3, 7);
            Console.WriteLine($"Range1: {range.from}, {range.to}");

            Range range1 = new Range(10, 15);
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

            Range[] unionRanges = range.GetUnion(range1);
            foreach (var sumRange in unionRanges)
            {
                Console.WriteLine($"Sum: [{sumRange.from}, {sumRange.to}]");
            }

            Range[] differenceRanges = range.GetDifference(range1);
            foreach (var differenceRange in differenceRanges)
            {
                Console.WriteLine($"Difference: [{differenceRange.from}, {differenceRange.to}]");
            }
        }
    }
}
