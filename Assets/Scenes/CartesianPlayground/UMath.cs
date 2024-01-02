using System;
using UnityEngine;

public class UMath
{
    static public float Dot(Coords vector1, Coords vector2)
    {
        return vector1.x * vector2.x + vector1.y * vector2.y;
    }

    static public float Dot(Vector3 vector1, Vector3 vector2)
    {
        return vector1.x * vector2.x + vector1.y * vector2.y;
    }


    static public float Angle(Coords vector1, Coords vector2)
    {
        float magV1 = (float)Math.Sqrt(Math.Pow(vector1.x, 2) + Math.Pow(vector1.y, 2));
        float magV2 = (float)Math.Sqrt(Math.Pow(vector2.x, 2) + Math.Pow(vector2.y, 2));

        return (float)Math.Acos(Dot(vector1, vector2) / (magV1 * magV2));
    }

    static public float Angle(Vector3 vector1, Vector3 vector2)
    {
        float magV1 = (float)Math.Sqrt(Math.Pow(vector1.x, 2) + Math.Pow(vector1.y, 2));
        float magV2 = (float)Math.Sqrt(Math.Pow(vector2.x, 2) + Math.Pow(vector2.y, 2));

        return (float)Math.Acos(Dot(vector1, vector2) / (magV1 * magV2));
    }

    static public float AngleDegres(Coords vector1, Coords vector2)
    {
        float magV1 = (float)Math.Sqrt(Math.Pow(vector1.x, 2) + Math.Pow(vector1.y, 2));
        float magV2 = (float)Math.Sqrt(Math.Pow(vector2.x, 2) + Math.Pow(vector2.y, 2));

        return (float)Math.Acos(Dot(vector1, vector2) / (magV1 * magV2)) * (180 / Mathf.PI);
    }

    static public bool IsDirectionClockWise(Vector3 v1, Vector3 v2)
    {
        Vector3 crossProduct = new Vector3(v1.y * v2.z - v1.z * v2.y, v1.x * v2.z - v1.z * v2.x, v1.x * v2.y - v1.y * v2.x);
        return crossProduct.z < 0;
    }

    static public Vector3 LookAt(Vector3 forwardVector, Vector3 position, Vector3 focusPoint)
    {
        Vector3 direction = (focusPoint - position).normalized;
        float angle = Angle(forwardVector, direction);
        bool clockwise = IsDirectionClockWise(forwardVector, direction);

        Vector3 newDir = RotateVector(forwardVector, angle, clockwise);

        return newDir;
    }

    static public Vector3 RotateVector(Vector3 vector, float angle, bool clockWise)
    {
        if (clockWise)
        {
            angle = 2 * Mathf.PI - angle;
        }

        float xVal = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);
        float yVal = vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle);

        return new Vector3(xVal, yVal, 0);
    }

    static public Vector3 Lerp(Vector3 a, Vector3 b, float t)
    {
        Vector3 v = b - a;
        return a + (v * Mathf.Clamp01(t));
    }
}
