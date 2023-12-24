using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    [SerializeField] int size;
    private int lastSize;

    private List<GameObject> generatedLines = new List<GameObject>();

    void Update()
    {
        if (lastSize != size)
        {
            size = Mathf.Clamp(size, 1, 60);
            lastSize = size;
            generatedLines.ForEach(p => Destroy(p));
            generatedLines.Clear();

            for (int y = 0; y < Camera.main.orthographicSize / size; y++)
            {
                generatedLines.Add(Coords.DrawLine(new Coords(-115.16f, y * size), new Coords(115.16f, y * size), .5f, Color.white));
                generatedLines.Add(Coords.DrawLine(new Coords(-115.16f, y * -size), new Coords(115.16f, y * -size), .5f, Color.white));
            }

            for (int x = 0; x < Camera.main.orthographicSize / size * 1.8f ; x++)
            {
                generatedLines.Add(Coords.DrawLine(new Coords(x * size, -65), new Coords(x * size, 65), .5f, Color.white));
                generatedLines.Add(Coords.DrawLine(new Coords(x * -size, -65), new Coords(x * -size, 65), .5f, Color.white));
            }
        }
    }
}
