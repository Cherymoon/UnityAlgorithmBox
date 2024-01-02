using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform start;
    public Transform end;
    Line line;

    void Start()
    {
        line = new Line(start.position, end.position, Line.LINETYPE.SEGMENT);
    }

    void Update()
    {
        transform.position = UMath.Lerp(start.position, end.position, Time.time * 0.05f);
    }
}
