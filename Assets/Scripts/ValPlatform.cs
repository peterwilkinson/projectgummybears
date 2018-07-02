using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValPlatform : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnMouseDown()
    {
        GetComponent<Animator>().SetTrigger("GoingUpPlat");
    }

    private void OnMouseUp()
    {
        GetComponent<Animator>().SetTrigger("GoingDownPlat");
    }


}
