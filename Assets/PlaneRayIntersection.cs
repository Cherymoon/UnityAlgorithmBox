using UnityEngine;

public class PlaneRayIntersection : MonoBehaviour
{
    public GameObject sphere;
    public Transform corner1;
    public Transform corner2;
    public Transform corner3;

    Plane mPlane;

    void Start()
    {
        mPlane = new Plane(corner1.position, corner2.position, corner3.position);
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
