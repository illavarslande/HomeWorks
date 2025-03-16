using System;

namespace Shape
{
    class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.PrintName();
            Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");
            Console.WriteLine($"Area: {circle.GetArea()}");

            Console.WriteLine();

            Rectangle rectangle = new Rectangle(3, 6);
            rectangle.PrintName();
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");
            Console.WriteLine($"Area: {rectangle.GetArea()}");

            Console.WriteLine();

            Triangle triangle = new Triangle(5, 7, 10);
            triangle.PrintName();
            Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}");
            Console.WriteLine($"Area: {triangle.GetArea()}");

            Console.WriteLine();

            Shape[] shapes = { circle, rectangle, triangle };
            foreach ( Shape shape in shapes )
            {
                shape.PrintName();
            }
        }
    }
}
