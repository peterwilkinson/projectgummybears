using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngeborgDay3Bird2D : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(3, 0);
           
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
        }
    }
}
