using System;
using System.Linq;

namespace Vector
{
    internal class Vector
    {
        private float[] data;
        public int Size { get; }

        public Vector(int size)
        {
            Size = size;
            data = new float[size];
        }

        public Vector(float[] values)
        {
            Size = values.Length;
            data = new float[Size];
            Array.Copy(values, data, Size);
        }

        public float Get(int index)
        {
            return data[index];
        }

        public void Set(int index, float value) 
        { 
            data[index] = value; 
        }

        public Vector Add(Vector other)
        {
            if (Size != other.Size)
            {
                throw new ArgumentException("The size of the arrays is not the same");
            }

            float[] resultVector = new float[Size];
            for (int i = 0; i < Size; i++)
            {
                resultVector[i] = data[i] + other.data[i];
            }
            return new Vector(resultVector);

        }

        public Vector Subrtact(Vector other) 
        {
            if (Size != other.Size)
            {
                throw new ArgumentException("The size of the arrays is not the same");
            }

            float[] resultVector = new float[Size];
            for (int i = 0; i < Size; i++)
            {
                resultVector[i] = data[i] - other.data[i];
            }
            return new Vector(resultVector);
        }

        public Vector MultiplyByScalar(float scalar)
        {

            float[] resultVector = new float[Size];
            for (int i = 0; i < Size; i++)
            {
                resultVector[i] = data[i] * scalar;
            }
            return new Vector(resultVector);
        }

        public float DotProduct(Vector other)
        {
            float result = 0;
            for (int i = 0; i < Size; i++)
            {
                result += data[i] * other.data[i];
            }
            return result;
        }

        public void Print()
        {
            System.Console.WriteLine(String.Join(",", data));
        }
    }
}
