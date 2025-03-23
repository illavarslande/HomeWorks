using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(new float[] { 2, 5, 8 });
            Vector vector2 = new Vector(new float[] { -2, 0, 7 });

            Vector sum = vector1.Add(vector2);
            sum.Print();
            Console.WriteLine();

            Vector substract = vector1.Subsrtact(vector2);
            substract.Print();
            Console.WriteLine();

            Vector multiplyByScalar = vector1.MultiplyByScalar(2);
            multiplyByScalar.Print();
            Console.WriteLine();

            float dotProduct = vector1.DotProduct(vector2);
            Console.WriteLine(dotProduct);
        }
    }
}
