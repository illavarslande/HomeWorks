using System;
using System.IO;

namespace FileConversationToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathForReader = "C:\\Users\\illav\\source\\repos\\HomeWorks\\FileConversionToUppercase\\note1.txt";
            string pathForWriter = "C:\\Users\\illav\\source\\repos\\HomeWorks\\FileConversionToUppercase\\note2.txt";
            string text;
            using (StreamReader reader = new StreamReader(pathForReader))
            {
                text = reader.ReadToEnd().ToUpper();
                Console.WriteLine(text);
            }
            using (StreamWriter writer = new StreamWriter(pathForWriter, false))
            {
                writer.WriteLine(text);
            }
        }
    }
}
