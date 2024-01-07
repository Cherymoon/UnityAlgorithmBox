using System.Threading;
using UnityEngine;

public class Transformations : MonoBehaviour
{
    public GameObject[] points;
    public float angle;
    public Vector3 translation;
    public Vector3 scaling;

    void Start()
    {
        foreach (GameObject point in points)
        {
            Coords position = new Coords(point.transform.position, 1);
            Coords newPos = HolisticMath.Scale(position, new Coords(new Vector3(scaling.x, scaling.y, scaling.z), 0));
            point.transform.position = newPos.ToVector();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void XXX()
    {

    }
}
