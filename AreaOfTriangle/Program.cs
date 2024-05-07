using System;

namespace AreaOfTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки А (x1, y1): ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B (x2, y2): ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки C (x3, y3): ");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double sideAB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double sideBC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double sideAC = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

            const double epsilon = 1.0e-10;

            if (Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2))) <= epsilon)
            {
                Console.WriteLine("Точки лежат на одной прямой.");
            }
            else
            {
                double semiperimetr = (sideAB + sideBC + sideAC) / 2;
                double triangleArea = Math.Sqrt(semiperimetr * (semiperimetr - sideAB) * (semiperimetr - sideBC) * (semiperimetr - sideAC));
                Console.WriteLine($"Площадь треугольника: {triangleArea}");
            }
        }
    }
}