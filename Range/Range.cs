
using System;
using System.Net.Http.Headers;

namespace Range
{
    class Range
    {
        public int from { get; private set; }
        public int to { get; private set; }
        public Range(int from, int to)
        {
            this.from = from;
            this.to = to;
        }

        public int Length()
        {
            return to - from;
        }

        public bool IsInside(int num)
        {
            bool result = num <= to && num >= from;
            return result;
        }

        public Range? GetIntersection(Range range)
        {
            int intersectFrom = Math.Max(from, range.from);
            int intersectTo = Math.Min(to, range.to);
            if (intersectFrom <= intersectTo)
            {
                return new Range(intersectFrom, intersectTo);
            }
            return null;
        }

        public Range[] GetUnion(Range range)
        {
            if (to >= range.from && from <= range.to)
            {
                int newFrom = Math.Min(from, range.from);
                int newTo = Math.Max(to, range.to);
                return new Range[] { new Range(newFrom, newTo) };
            }
            if (from <= range.from && to >= range.to)
            {
                return new Range[] { new Range(from, to) };
            }

            if (range.from <= from && range.to >= to)
            {
                return new Range[] { new Range(range.from, range.to) };
            }

            return new Range[] { new Range(from, to), new Range(range.from, range.to) };
        }

        public Range[] GetDifference(Range range)
        {
            if (to < range.from || from > range.to)
            {
                return new Range[] { new Range(from, to) };
            }
            if (range.from < from && range.to > to)
            {
                return new Range[0];
            }

            List<Range> result = new List<Range>();

            if (from < range.from)
            {
                result.Add(new Range(from, range.from));
            }
            if (to > range.to)
            {
                result.Add(new Range(range.to, to));
            }

            return result.ToArray();
        }

    }

}
