using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseUnlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
