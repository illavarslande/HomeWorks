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
            do
            {
                if (!char.IsLetter(text[start]))
                {
                    start++;
                }
                if (!char.IsLetter(text[end]))
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
            while (start < end / 2);
            Console.WriteLine("Yout text is palindrome.");
        }
    }
}