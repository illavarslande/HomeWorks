
namespace Shape
{
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
}
