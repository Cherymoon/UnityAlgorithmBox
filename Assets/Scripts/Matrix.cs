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
                matrix += values[i+j];

                if(j != cols-1)
                {
                    matrix += ",";
                }
            }
            matrix += "]\n";
        }

        return matrix;
    }
}
