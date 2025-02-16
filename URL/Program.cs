using System;

namespace URL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://SomeServerName/abcd/dfdf.htm?dfdf=dfdf";
            int startIndex = url.IndexOf("://");
            startIndex += 3;
            int endIndex = url.IndexOf("/", startIndex);
            if (endIndex == -1)
            {
                string result1 = url.Substring(startIndex);
                Console.WriteLine(result1);
            }
            else
            {
                string result = url.Substring(startIndex, endIndex - startIndex);
                Console.WriteLine(result);
            }
        }
    }
}
