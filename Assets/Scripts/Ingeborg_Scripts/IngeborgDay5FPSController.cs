using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngeborgDay5FPSController : MonoBehaviour
{

    private GameObject startSpawnPoint;

    // Use this for initialization
    void Start()
    {
        startSpawnPoint = GameObject.Find("StartSpawnPoint").gameObject;

        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -20.0f)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        gameObject.transform.position = startSpawnPoint.transform.position;
        gameObject.transform.rotation = startSpawnPoint.transform.rotation;
    }
}