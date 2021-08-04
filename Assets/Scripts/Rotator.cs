using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed = 45f;

    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0);
    }
}
