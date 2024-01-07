using System;
using System.Diagnostics;
using UnityEngine;

public class Matrix
{
    public float[] values;
    int rows;
    int cols;

    public Matrix(int r, int c, float[] v)
    {
        rows = r;
        cols = c;
        values = new float[rows * cols];
        Array.Copy(v, values, rows * cols);
    }

    public Coords AsCoords()
    {
        if (rows == 4 && cols == 1)
        {
            return new Coords(values[0], values[1], values[2], values[3]);
        }
        else
        {
            return null;
        }
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

    static public Matrix operator *(Matrix a, Matrix b)
    {
        if (a.cols == b.rows)
        {
            float[] resultValues = new float[a.rows * b.cols];

            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < b.cols; j++)
                {
                    for (int k = 0; k < a.cols; k++)
                    {
                        resultValues[i * b.cols + j] += a.values[i * a.cols + k] * b.values[k * b.cols + j];
                    }
                }
            }

            Matrix result = new Matrix(a.rows, b.cols, resultValues);
            return result;
        }
        else
        {
            UnityEngine.Debug.Log(a.rows + ":" + b.cols);
            throw new Exception("The number of rows of matrix A must match the number os columns of B!");
        }
    }
}
