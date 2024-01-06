using System;

public class Matrix
{
    float[] values;
    int rows;
    int cols;

    public Matrix(int r, int c, float[] v)
    {
        rows = r;
        cols = c;
        values = new float[rows * cols];
        Array.Copy(v, values, rows * cols);
    }

    public override string ToString()
    {
        string matrix = "";

        for (int i = 0; i < rows; i++)
        {
            matrix += "[";
            for (int j = 0; j < cols; j++)
            {
                matrix += values[i * cols + j];

                if (j != cols - 1)
                {
                    matrix += ",";
                }
            }
            matrix += "]\n";
        }

        return matrix;
    }

    static public Matrix operator +(Matrix a, Matrix b)
    {
        if (a.cols == b.cols && a.rows == b.rows)
        {
            float[] v = new float[a.rows * a.cols];

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = a.values[i] + b.values[i];
            }

            return new Matrix(a.rows, a.cols, v);
        }
        else
        {
            throw new Exception("The two matrixes must be the same length!");
        }
    }
}
