using System;
using UnityEngine;

public class UMath
{
    static public float Dot(Coords vector1, Coords vector2)
    {
        return vector1.x * vector2.x + vector1.y * vector2.y;
    }

    static public float Angle(Coords vector1, Coords vector2)
    {
        float magV1 = (float)Math.Sqrt(Math.Pow(vector1.x, 2) + Math.Pow(vector1.y, 2));
        float magV2 = (float)Math.Sqrt(Math.Pow(vector2.x, 2) + Math.Pow(vector2.y, 2));

        return (float)Math.Acos(Dot(vector1, vector2) / magV1 * magV2);
    }

    static public float AngleDegres(Coords vector1, Coords vector2)
    {
        float magV1 = (float)Math.Sqrt(Math.Pow(vector1.x, 2) + Math.Pow(vector1.y, 2));
        float magV2 = (float)Math.Sqrt(Math.Pow(vector2.x, 2) + Math.Pow(vector2.y, 2));
        float dotDivide = Dot(vector1, vector2) / (magV1 * magV2);

        float angle = Mathf.Acos(dotDivide) * 180/ Mathf.PI;
        Debug.Log("ang " + angle);

        return angle;
    }
}
