using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KahDay3_3D : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().velocity = new Vector2(5, 0);  
	}
}
