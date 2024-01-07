using UnityEngine;

public class Transformations : MonoBehaviour
{
    public GameObject[] points;
    public Vector3 translation;
    public Vector3 scaling;
    public Vector3 rotation;
    public GameObject center;

    void Start()
    {
        Vector3 c = new Vector3(center.transform.position.x, center.transform.position.y, center.transform.position.z);
        foreach (GameObject point in points)
        {
            Coords position = new Coords(point.transform.position, 1);

            position = HolisticMath.Translate(position, new Coords(new Vector3(-c.x, -c.y, -c.z), 0));

            position = HolisticMath.Scale(position, new Coords(new Vector3(scaling.x, scaling.y, scaling.z)));

            point.transform.position = HolisticMath.Translate(position, new Coords(new Vector3(c.x, c.y, c.z), 0)).ToVector();
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
