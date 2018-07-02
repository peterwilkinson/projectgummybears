using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeterDay5GameControl : MonoBehaviour {

    public int score;
    public int lives;
    public GameObject player;
    public GameObject spawnPoint;
    public float fellTooFarBelow;
    public Text scoreText;
    public Text livesText;
    public Image healthImage;

    // Start is called just before any of the Update methods is called the first time
    private void Start()
    {
        SpawnPlayer();
    }

    // Update is called every frame, if the MonoBehaviour is enabled
    private void Update()
    {
        if(player.transform.position.y < fellTooFarBelow)
        {
            lives -= 1;
            SpawnPlayer();
        }
    }

    // spawn the player at a point in the world
    private void SpawnPlayer()
    {
        player.transform.position = spawnPoint.transform.position;
    }



}
