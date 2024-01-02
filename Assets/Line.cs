using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Line
{
    public Vector3 A;
    public Vector3 B;
    public Vector3 v;

    public enum LINETYPE { LINE, SEGMENT, RAY };
    LINETYPE type;

    public Line(Vector3 A, Vector3 B, LINETYPE type)
    {
        this.A = A;
        this.B = B;
        this.v = B - A;
        this.type = type;
    }

    public Vector3 Lerp(float t)
    {
        if (type == LINETYPE.LINE)
        {
            t = Mathf.Clamp(t, float.MinValue, float.MaxValue);
        }
        else if (type == LINETYPE.SEGMENT)
        {
            t = Mathf.Clamp01(t);
        }
        else if (type == LINETYPE.RAY)
        {
            t = Mathf.Clamp(t, 0, float.MaxValue);
        }

        return A + (v * t);
    }
}
