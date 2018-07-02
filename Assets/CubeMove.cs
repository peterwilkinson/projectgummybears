using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
		

        if (Input.GetKey(KeyCode.D))
        {

            GetComponent<Rigidbody>().velocity = new Vector2(2, 2);


        }

	}
}
