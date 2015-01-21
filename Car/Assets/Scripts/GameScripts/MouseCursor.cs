using UnityEngine;
using System.Collections;

public class MouseCursor : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        Screen.showCursor = false;
        Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Screen.showCursor =! Screen.showCursor;
            Screen.lockCursor =! Screen.lockCursor;
        }
	}
}
