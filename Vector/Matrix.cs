
namespace VectorsMatrix
{
    internal class Matrix
    {
        public Vector[] rows;

        public int RowCount => rows.Length;
        public int ColCount => rows.Length > 0 ? rows[0].Size : 0;

        public Matrix(int rowCount, int colCount)
        {  
            rows = new Vector[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                rows[i] = new Vector(colCount);
            }
        }

        public Matrix(Vector[] rowVectors)
        {
            if (rowVectors.Length == 0)
            {
                throw new ArgumentException("Empty matrix.");
            }
            
            int matrixSize = rowVectors[0].Size;
            foreach (var row in rowVectors)
            {
                if (matrixSize != row.Size)
                {
                    throw new ArgumentException("The strings must have the same length.");
                }
            }

            rows = (Vector[])rowVectors.Clone();
        }

        public Vector GetRow(int index)
        {
            return rows[index];
        }

        public void SetRow(int index, Vector row)
        {
            rows[index] = row;
        }

        public float Get(int row, int col)
        {
            return rows[row].Get(col);
        }

        public void Set(int row, int col, float value)
        {
            rows[row].Set(col, value);
        }

        public Matrix Add(Matrix other)
        {
            Vector[] result = new Vector[RowCount];
            for(int i = 0; i < RowCount; i++)
            {
                result[i] = rows[i].Add(other.rows[i]); 
            }
            return new Matrix(result);
        }

        public Matrix Subtract(Matrix other)
        {
            Vector[] result = new Vector[RowCount];
            for (int i = 0; i < RowCount; i++)
            {
                result[i] = rows[i].Subtract(other.rows[i]);
            }
            return new Matrix(result);
        }

        public Matrix MultiplyByScalar(float scalar)
        {
            Vector[] result = new Vector[RowCount];
            for (int i = 0; i < RowCount; i++)
            {
                result[i] = rows[i].MultiplyByScalar(scalar);
            }
            return new Matrix(result);
        }

        public Vector Multiply(Vector vec)
        {
            float[] result = new float[RowCount];
            for (int i = 0; i < RowCount; i++)
            {
                result[i] = rows[i].DotProduct(vec);
            }
            return new Vector(result);
        }

        public Matrix Multiply(Matrix other)
        {
            if (this.ColCount != other.RowCount)
            {
                throw new ArgumentException("The number of columns of the first matrix must match the number of rows of the second matrix.");
            }

            int resultRows = this.RowCount;
            int resultCols = other.ColCount;
            Vector[] resultVectors = new Vector[resultRows];

            for (int i = 0; i < resultRows; i++)
            {
                float[] resultRow = new float[resultCols];

                for (int j = 0; j < resultCols; j++)
                {
                    float sumDotElements = 0;

                    for (int k = 0; k < this.ColCount; k++)
                    {
                        float element1 = this.Get(i, k);
                        float element2 = other.Get(k, j);
                        sumDotElements += element1 * element2;
                    }

                    resultRow[j] = sumDotElements;
                }

                resultVectors[i] = new Vector(resultRow);
            }

            return new Matrix(resultVectors);
        }

        public void Print()
        {
            for (int i = 0; i < this.RowCount; i++)
            {
                rows[i].Print();
            }
        }
    }
}
