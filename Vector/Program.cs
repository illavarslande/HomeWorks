using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(new float[] { 2, 5, 8 });
            Vector vector2 = new Vector(new float[] { -2, 0, 7 });

            Console.Write("Vector 1: ");
            vector1.Print();

            Console.Write("Vector 2: ");
            vector2.Print();

            Console.WriteLine();

            Vector sum = vector1.Add(vector2);
            Console.Write("Sum of vectors: ");
            sum.Print();
            Console.WriteLine();

            Vector substract = vector1.Subrtact(vector2);
            Console.Write("Difference of vectors: ");
            substract.Print();
            Console.WriteLine();

            Vector multiplyByScalar = vector1.MultiplyByScalar(2);
            Console.Write("Scalar multiplication of Vector 1: ");
            multiplyByScalar.Print();
            Console.WriteLine();

            float dotProduct = vector1.DotProduct(vector2);
            Console.Write("Dot product: ");
            Console.WriteLine(dotProduct);
        }
    }
}
