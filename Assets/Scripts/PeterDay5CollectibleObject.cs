using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeterDay5CollectibleObject : MonoBehaviour {
    
    private Text score;
    private PeterDay5GameControl gameControl;

    private void Start()
    {
        score = GameObject.Find("ScoreText").GetComponent<Text>();
        gameControl = GameObject.Find("GameControl").GetComponent<PeterDay5GameControl>();
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }

    // This function is called when the MonoBehaviour will be destroyed
    private void OnDestroy()
    {
        gameControl.score += 100;
        score.text = "Score: " + gameControl.score.ToString();
    }
}