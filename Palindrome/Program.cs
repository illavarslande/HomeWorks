using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string text = Console.ReadLine();

            int start = 0;
            int end = text.Length - 1;
            while (start < end)
            {
                while (start < end && !char.IsLetter(text[start]))
                {
                    start++;
                }
                while (start < end && !char.IsLetter(text[end]))
                {
                    end--;
                }
                if (char.ToLower(text[start]) != char.ToLower(text[end]))
                {
                    Console.WriteLine("Your text is not palindrome.");
                    return;
                }
                start++;
                end--;
            }
            Console.WriteLine("Yout text is palindrome.");
        }
    }
}