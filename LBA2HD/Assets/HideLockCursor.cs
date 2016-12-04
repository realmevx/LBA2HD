using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideLockCursor : MonoBehaviour {

	public bool lockCursor = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			lockCursor = !lockCursor;
		}

		Cursor.lockState = lockCursor ? CursorLockMode.Locked : CursorLockMode.None;
		Cursor.visible = !lockCursor;
	}
}
