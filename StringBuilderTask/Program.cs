using System;
using System.Text;

namespace StringBuilderTask
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 101; i++)
            {
                sb = sb.Append(i).Append(",");
            }
            int endIndex = sb.Length - 1;
            sb = sb.Remove(endIndex, 1);
            Console.WriteLine(sb);
        }
    }
}
