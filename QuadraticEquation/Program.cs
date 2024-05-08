using System;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый коэффициент: ");
            double coefficientFirst = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй коэффициент: ");
            double coefficientSecond = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий коэффициент: ");
            double coefficientThird = double.Parse(Console.ReadLine());

            const double epsilon = 1e-10;

            if (Math.Abs(coefficientFirst) <= epsilon)
            {
                if (Math.Abs(coefficientSecond) <= epsilon)
                {
                    if (Math.Abs(coefficientThird) <= epsilon)
                    {
                        Console.WriteLine("Уравнение имеет бесконечное количесво корней.");
                    }
                    else
                    {
                        Console.WriteLine("Уравнение не имеет решений.");
                    }

                }
                else
                {
                    double rootFirst = -coefficientThird / coefficientSecond;
                    Console.WriteLine($"Это не квадратное уравнение. Но данное уравнение имеет один корень x1 = {rootFirst}");
                }
            }
            else
            {
                double discriminant = Math.Pow(coefficientSecond, 2) - 4 * coefficientFirst * coefficientThird;

                if (discriminant > epsilon)
                {
                    double rootFirst = (-coefficientSecond + Math.Sqrt(discriminant)) / (2 * coefficientFirst);
                    double rootSecond = (-coefficientSecond - Math.Sqrt(discriminant)) / (2 * coefficientFirst);
                    Console.WriteLine($"Уравнение имеет два корня x1 = {rootFirst}, x2 = {rootSecond}");
                }
                else if (Math.Abs(discriminant) <= epsilon)
                {
                    double rootFirst = -coefficientSecond / (2 * coefficientFirst);
                    Console.WriteLine($"Уравнение имеет один корень x1 = {rootFirst}");
                }
                else
                {
                    Console.WriteLine("Корней нет :(");
                }
            }
        }
    }
}
