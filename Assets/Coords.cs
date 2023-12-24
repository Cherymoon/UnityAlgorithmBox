using UnityEngine;

public class Coords
{
    public float x;
    public float y;
    public float z;

    public Coords(float x, float y)
    {
        this.x = x;
        this.y = y;
        this.z = -1;
    }

    public override string ToString()
    {
        return $"({x},{y},{z})";
    }

    public void DrawPoint(float width, Color color)
    {
        GameObject line = new GameObject("Point_" + ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = color;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(x - width/3f, y - width/3f, z));
        lineRenderer.SetPosition(1, new Vector3(x + width/3f, y - width/3f, z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    } 

    public static void DrawLine(Coords startPoint, Coords endPoint, float width, Color color)
    {
        GameObject line = new GameObject($"Line_{startPoint.ToString()}-{endPoint.ToString()}");
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = color;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(startPoint.x, startPoint.y, startPoint.z));
        lineRenderer.SetPosition(1, new Vector3(endPoint.x, endPoint.y, endPoint.z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
}
