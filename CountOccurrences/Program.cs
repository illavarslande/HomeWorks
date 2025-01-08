using System;

namespace CountOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\illav\\source\\repos\\HomeWorks\\CountOccurrences\\note1.txt";
            using (StreamReader text = new StreamReader(path))
            {
                int result = GetCharCount(text.ReadToEnd());
                Console.WriteLine(result);
            }
        }

        static int GetCharCount(string text)
        {
            string chars = "at";
            int count = 0;
            int index = text.IndexOf(chars, StringComparison.OrdinalIgnoreCase);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(chars, index + 1, StringComparison.OrdinalIgnoreCase);
            }
            return count;
        }
    }
}
