
namespace Shape
{
    class Triangle : Shape
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }
        public Triangle(double side1, double side2, double side3) : base("Triangle")
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override double GetPerimeter()
        {
            double perimeter = Side1 + Side2 + Side3;
            return perimeter;
        }
        public override double GetArea()
        {
            double perimeter = GetPerimeter();
            double area = Math.Sqrt(perimeter / 2 * (perimeter / 2 - Side1) * (perimeter / 2 - Side2) * (perimeter / 2 - Side3));
            return area;
        }
    }
}
