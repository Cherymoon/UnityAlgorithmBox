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

        rotation = rotation * Mathf.Deg2Rad;

        foreach (GameObject point in points)
        {
            Coords position = new Coords(point.transform.position, 1);

            position = HolisticMath.Translate(position, new Coords(new Vector3(-c.x, -c.y, -c.z), 0));
            position = HolisticMath.Rotate(position, rotation.x, true, rotation.y, true, rotation.z, true);
            point.transform.position = HolisticMath.Translate(position, new Coords(new Vector3(c.x, c.y, c.z), 0)).ToVector();

            /*

            position = HolisticMath.Scale(position, new Coords(new Vector3(scaling.x, scaling.y, scaling.z)));

            */
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
