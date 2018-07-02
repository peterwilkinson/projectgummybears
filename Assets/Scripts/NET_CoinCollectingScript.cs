using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NET_CoinCollectingScript : MonoBehaviour {

    public Text NETscore;
    public 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //onTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        print(other);
        if (other.gameObject.tag == "Player")
        { 
        Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        NETscore.text += "you bitch!"; 
    }
}
