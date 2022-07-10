using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{

    public float x = 0f;
    public float y = 0.25f;
    public float z = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x, y, z);
    }
}
