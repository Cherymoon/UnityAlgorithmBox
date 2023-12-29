using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Fly : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float speed = 1.0f;

    void Update()
    {
        RotateHandler();
    }

    public void TranslateHandler()
    {
        float translateX = Input.GetAxis("Horizontal") * speed;
        float translateY = Input.GetAxis("VerticalY") * speed;
        float translateZ = Input.GetAxis("Vertical") * speed;

        transform.Translate(new Vector3(translateX, translateY, translateZ));
    }

    public void RotateHandler()
    {
        float rotationX = Input.GetAxis("Vertical") * speed;
        float rotationY = Input.GetAxis("Horizontal") * speed;
        float rotationZ = Input.GetAxis("HorizontalZ") * speed;

        transform.Rotate(rotationX, rotationY, rotationZ);
    }
}
