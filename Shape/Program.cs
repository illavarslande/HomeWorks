using System;

namespace Shape
{
    class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.PrintName();
            Console.WriteLine($"Area: {circle.GetArea()}");
            Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");

            Console.WriteLine();

            Rectangle rectangle = new Rectangle(3, 6);
            rectangle.PrintName();
            Console.WriteLine($"Area: {rectangle.GetArea()}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");
        }
    }
}
