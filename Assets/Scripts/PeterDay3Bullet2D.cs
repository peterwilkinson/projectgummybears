using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeterDay3Bullet2D : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(transform.gameObject, 1);
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
	}
}
