using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngeborgDay5CollectibleObject : MonoBehaviour
{

    private Text score;
    private IngeborgDay5GameControl gameControl;

    private void Start()
    {
        score = GameObject.Find("ScoreText").GetComponent<Text>();
        gameControl = GameObject.Find("GameControl").GetComponent<IngeborgDay5GameControl>();
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
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