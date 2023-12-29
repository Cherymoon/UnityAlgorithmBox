using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject objPrefab;

    void Start()
    {
        GameObject obj = Instantiate(objPrefab, new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), 0), Quaternion.identity);
    }

    void Update()
    {

    }
}
