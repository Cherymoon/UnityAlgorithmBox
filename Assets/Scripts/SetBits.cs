using System;
using UnityEngine;

public class SetBits : MonoBehaviour
{
    [SerializeField] int bitSequence = 1;

    void Start()
    {
        Debug.Log(Convert.ToString(bitSequence, 2));
    }

    void Update()
    {

    }
}
