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

    static public void LookTo(GameObject gameObject, Vector3 positionToLook)
    {
        Vector3 lookupDirection = (positionToLook - gameObject.transform.position).normalized;

        bool rotateClockwise = IsDirectionClockWise(gameObject.transform.up, lookupDirection);
        float angle = Angle(new Coords(gameObject.transform.up.x, gameObject.transform.up.y), new Coords(lookupDirection.x, lookupDirection.y));

        gameObject.transform.up = RotateVector(gameObject.transform.up, angle, rotateClockwise);
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
}
