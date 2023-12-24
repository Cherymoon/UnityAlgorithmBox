using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    Coords point = new Coords(10, 10);

    void Start()
    {
        Debug.Log(point.ToString());
        point.DrawPoint(1, Color.green);

        new Coords(0, 0).DrawPoint(1, Color.red);

        Coords.DrawLine(new Coords(-115.6f, 0), new Coords(115.6f, 0), .5f, Color.green);
        Coords.DrawLine(new Coords(0, -65), new Coords(0, 65), .5f, Color.green);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
