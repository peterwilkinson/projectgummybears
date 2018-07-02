using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaizeDay6GameControl : MonoBehaviour {

    public int score;
    public int lives;
    public GameObject player;
    public GameObject spawnPoint;
    public float fellTooFarHeight;
    public Text scoreText;
    public Text livesText;
    public Image healthImage;

    private void Start()
    {
        SpawnPlayer();
    }

    private void Update()
    {
       if(player.transform.position.y < fellTooFarHeight)
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