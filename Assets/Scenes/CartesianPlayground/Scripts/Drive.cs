using UnityEngine;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{
    public GameObject fuel;
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Start()
    {
    }

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        Translate(transform, new Vector3(0, translation, 0));

        // Rotate around our y-axis
        transform.Rotate(0, 0, -rotation);
    }

    void Translate(Transform transform, Vector3 dir)
    {
        if(Vector3.Distance(Vector3.zero, dir) == 0) return;
        
        float angleYAxis = UMath.Angle(dir, transform.up);
        float angleNormal = UMath.Angle(Vector3.up, dir);

        if (UMath.IsDirectionClockWise(dir, transform.up))
        {
            angleYAxis = 2 * Mathf.PI - angleYAxis;
        }

        dir = UMath.RotateVector(dir, angleNormal, UMath.IsDirectionClockWise(dir, transform.up));


        float velX = -dir.y * Mathf.Sin(angleYAxis);
        float velY = dir.y * Mathf.Cos(angleYAxis);


        transform.position += new Vector3(velX, velY, 0);
    }


}