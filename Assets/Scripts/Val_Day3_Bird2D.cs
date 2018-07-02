using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Val_Day3_Bird2D : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, 1f);
        }

        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 1f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
        }

        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5);
        }


    }
}
