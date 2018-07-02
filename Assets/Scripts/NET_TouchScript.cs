using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NET_TouchScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider
    private void OnMouseDown()
    {
        GetComponent<Animator>().SetTrigger("NET_JumpTrigger");
    }



}
