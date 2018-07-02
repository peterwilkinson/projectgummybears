using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Val_Day3_Bird3D : MonoBehaviour
{
    bool isJumping = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity = new Vector2(5, 0.5f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity = new Vector2(-5, 0.5f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            isJumping = true;
            GetComponent<Rigidbody>().velocity = new Vector3(0, 15, 0.5f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;  
    }
}
