using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Val_Day3_Bird2D1 : MonoBehaviour
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
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 1);
        }
    }
}

