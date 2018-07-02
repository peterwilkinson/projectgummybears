using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngeborgDay3Cube3D : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(3, 0, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-3, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 3);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }
    }
}
