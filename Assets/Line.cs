using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line
{
    public Vector3 A;
    public Vector3 B;
    public Vector3 v;

    public Line(Vector3 A, Vector3 B)
    {
        this.A = A;
        this.B = B;
        this.v = B - A;
    }

    public Vector3 GetPointAt(float t)
    {
        return A + (v * t);
    }
}
