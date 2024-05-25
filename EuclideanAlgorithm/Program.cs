using System;

namespace EuclideanAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            string numberFirstInput = Console.ReadLine();

            Console.Write("Введите второе число: ");
            string numberSecondInput = Console.ReadLine();

            if (!int.TryParse(numberFirstInput, out int numberFirst) || !int.TryParse(numberSecondInput, out int numberSecond))
            {
                Console.WriteLine("Вы ввели некорректные значения.");
            }
            else
            {
                int changeNumberFirst = numberFirst;
                int changeNumberSecond = numberSecond;
                int nod = 0;

                while (changeNumberFirst % changeNumberSecond != 0)
                {
                    int remainder = changeNumberFirst % changeNumberSecond;
                    changeNumberFirst = numberSecond;
                    changeNumberSecond = remainder;

                    nod = changeNumberSecond;
                }
                Console.WriteLine($"НОД {numberFirst} и {numberSecond} = {nod}");
            }
        }
    }
}
