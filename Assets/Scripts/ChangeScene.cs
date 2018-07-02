using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public string scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if(Input.GetKeyDown(KeyCode.Space)){
        //    SceneManager.LoadScene("Peter_Day2");
        //}
	}

    // OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider
    private void OnMouseDown()
    {
        SceneManager.LoadScene(scene);
    }



}
