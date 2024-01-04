using UnityEngine;

public class PlaneRayIntersection : MonoBehaviour
{
    public GameObject sphere;
    public GameObject quad;

    Plane mPlane;

    void Start()
    {
        Vector3[] vertices = quad.GetComponent<MeshFilter>().mesh.vertices;
        mPlane = new Plane(quad.transform.TransformPoint(vertices[0]), quad.transform.TransformPoint(vertices[1]), quad.transform.TransformPoint(vertices[2]));
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float t = 0.0f;

            if (mPlane.Raycast(ray, out t))
            {
                Vector3 hitpoint = ray.GetPoint(t);
                sphere.transform.position = hitpoint;
            }
        }
    }
}
