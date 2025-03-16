
namespace Shape
{
    interface IShape
    {
        void PrintName();
        abstract double GetArea();
        abstract double GetPerimeter();
    }

    abstract class Shape : IShape
    {
        protected string _name { get; }

        public Shape(string name) 
        {
            _name = name;
        }
        public void PrintName() 
        {
            Console.WriteLine($"Shape is {_name}"); 
        }
        public abstract double GetArea();

        public abstract double GetPerimeter();
    }

    class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
        public override double GetPerimeter() => Math.PI * Radius * 2;
    }

    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double heigth) : base("Rectangle")
        {
            Width = width;
            Height = heigth;
        }
        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => (Height + Width) * 2;
    }
}
