using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{

    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instructions();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Instructions()
    {
        Debug.Log("Instructions:");
        Debug.Log("WASD to move");
        Debug.Log("Don't hit the walls");
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, 0, z);
    }
}
