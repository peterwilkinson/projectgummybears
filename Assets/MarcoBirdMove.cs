using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarcoBirdMove : MonoBehaviour {

    public GameObject Ball;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.D))
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(2, 2);


        }


        if(Input.GetKeyDown(KeyCode.Space))
        
        {
            Instantiate(Ball,transform.position,transform.rotation);
        }


	}


}
