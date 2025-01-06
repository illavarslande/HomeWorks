using System;

namespace StringSplitting
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "1, 2, 3, 4, 5";
            string[] subs = numbers.Split(',');
            int[] result = new int[subs.Length];
            int sum = 0;

            for (int i = 0; i < subs.Length; i++)
            {
                if (int.TryParse(subs[i], out int number))
                {
                    result[i] = number;
                    sum += number;
                    Console.Write(result[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
