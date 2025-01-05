using System;

namespace URL
{
    class Programm
    {
        static void Main(string[] args)
        {
            string url = "https://SomeServerName/abcd/dfdf.htm?dfdf=dfdf";
            string chars = "SomeServerName";
            int startIndex = url.IndexOf(chars);
            string result = url.Substring(startIndex, chars.Length);
            Console.WriteLine(result);
        }
    }
}
