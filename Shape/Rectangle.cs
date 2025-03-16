
namespace Shape
{
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
