using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5,0);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5);
        }
       

    }
}
