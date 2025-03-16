
namespace Shape
{
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
}
