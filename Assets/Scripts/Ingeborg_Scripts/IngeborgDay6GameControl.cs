using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngeborgDay6GameControl : MonoBehaviour
{

    public int score;
    public int lives;
    public float fellTooFarHeight;
    public GameObject player;
    public GameObject spawnPoint;
    public Text scoreText;
    public Text livesText;
    public Image healthImage;

    private void Start()
    {
        SpawnPlayer();
    }

    private void Update()
    {
        if (player.transform.position.y < fellTooFarHeight)
        {
            lives -= 1;
            SpawnPlayer();
        }
    }

    private void SpawnPlayer()
    {
        player.transform.position = spawnPoint.transform.position;
    }

   
}
