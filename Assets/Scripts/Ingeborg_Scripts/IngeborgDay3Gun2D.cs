using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngeborgDay3Gun2D : MonoBehaviour {
    public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
	}
}
