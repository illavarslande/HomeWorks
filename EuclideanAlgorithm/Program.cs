using System;

namespace EuclideanAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            string number1Input = Console.ReadLine();

            Console.Write("Введите второе число: ");
            string number2Input = Console.ReadLine();

            if (!int.TryParse(number1Input, out int number1) || !int.TryParse(number2Input, out int number2))
            {
                Console.WriteLine("Вы ввели некорректные значения.");
            }
            else
            {
                int temp1 = number1;
                int temp2 = number2;

                while (temp2 != 0)
                {
                    int remainder = temp1 % temp2;
                    temp1 = temp2;
                    temp2 = remainder;
                }
                Console.WriteLine($"НОД {number1} и {number2} = {temp1}");
            }
        }
    }
}
