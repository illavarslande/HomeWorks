using System;

namespace VectorsMatrix
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

            Vector substract = vector1.Subtract(vector2);
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

            Console.WriteLine();
            Console.WriteLine();

            Matrix matrix1 = new Matrix(new Vector[]
            {
                new Vector(new float[] {1, 5, 7}),
                new Vector(new float[] {3, 2, 3})
            });

            Matrix matrix2 = new Matrix(new Vector[]
            {
            new Vector(new float[] {0, 5, 10}),
            new Vector(new float[] {3, 2, 6})
            });

            Console.WriteLine();
            Console.WriteLine("Matrix1:");
            matrix1.Print();
            Console.WriteLine("Matrix2:");
            matrix2.Print();

            Matrix sumMatrix = matrix1.Add(matrix2);
            Console.WriteLine("Matrix1 + Matrix2:");
            sumMatrix.Print();

            Matrix diffMatrix = matrix1.Subtract(matrix2);
            Console.WriteLine("Matrix1 - Matrix2:");
            diffMatrix.Print();

            Matrix scaledMatrix = matrix1.MultiplyByScalar(2);
            Console.WriteLine("matrix1 * 2:");
            scaledMatrix.Print();

            Vector vec = new Vector(new float[] { 0, 1, 4 });
            Vector resultMultiplyVec = matrix1.Multiply(vec);
            Console.WriteLine("matrix1 * [0, 1, 4]:");
            resultMultiplyVec.Print();

            Matrix matrix3 = new Matrix(new Vector[]
            {
            new Vector(new float[] {1, 2}),
            new Vector(new float[] {2, 4}),
            new Vector(new float[] {0, 1})
            });

            Matrix productMultiplyMatrix = matrix1.Multiply(matrix3);
            Console.WriteLine("Matrix1 * Matrix3:");
            productMultiplyMatrix.Print();
        }
    }
}
