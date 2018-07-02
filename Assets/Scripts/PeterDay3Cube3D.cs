using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeterDay3Cube3D : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // The Faster Way
        GetComponent<Rigidbody>().velocity = new Vector3(Input.GetAxis("Horizontal")*5, 0, Input.GetAxis("Vertical")*5);




        // LEFT And RIGHT
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
        }

        // FORWARD And BACKWARD
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
        }

	}
}
