using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
       
            GetComponent<Rigidbody>().velocity = new Vector3(5, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
       
            GetComponent<Rigidbody>().velocity = new Vector3(-5, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5);
        }

    }
}
