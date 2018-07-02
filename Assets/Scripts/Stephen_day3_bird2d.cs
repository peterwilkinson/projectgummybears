using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stephen_day3_bird2d : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D))	{
            GetComponent<Rigidbody2D>().velocity = new Vector2(5, 1);
               GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 1);
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
	}
}
