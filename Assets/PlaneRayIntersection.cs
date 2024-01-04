using UnityEngine;

public class PlaneRayIntersection : MonoBehaviour
{
    public GameObject sheep;
    public GameObject quad;

    Plane mPlane;

    void Start()
    {
        Vector3[] vertices = quad.GetComponent<MeshFilter>().mesh.vertices;
        Vector3 yOffset = new Vector3(0, 0.3f, 0);
        mPlane = new Plane(quad.transform.TransformPoint(vertices[0]) + yOffset, quad.transform.TransformPoint(vertices[1]) + yOffset, quad.transform.TransformPoint(vertices[2]) + yOffset);
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
                sheep.transform.position = hitpoint;
            }
        }
    }
}
