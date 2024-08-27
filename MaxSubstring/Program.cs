using System;

namespace MaxSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            int maxSubstring = 0;
            int currentSubstring = 1;
            Console.WriteLine(str.Length);

            for (int i = 0; i <= str.Length - 1; i++)
            {
                if ((i + 1 < str.Length) && str[i] == str[i + 1])
                {
                    currentSubstring++;
                }
                else
                {
                    if (currentSubstring > maxSubstring)
                        maxSubstring = currentSubstring;
                    currentSubstring = 1;
                }
            }
            Console.WriteLine(maxSubstring);
        }
    }
}
