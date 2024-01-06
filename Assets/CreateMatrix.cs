using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float[] x = new float[6] { 1, 2, 3, 4, 5, 6 };
        float[] y = new float[6] { 1, 2, 3, 4, 5, 6 };

        Matrix m = new Matrix(2, 3, x);
        Matrix m2 = new Matrix(3, 2, y);

        Debug.Log((m * m2).ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
