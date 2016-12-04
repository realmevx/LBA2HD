using UnityEngine;
using System.Collections;
using System;

public class GameMaster : MonoBehaviour {

	public bool lockCursor = true;

	void Awake () {

		Cursor.visible = (false);

	}

	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			lockCursor = !lockCursor;
		}

		if (lockCursor) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		} else {
			Cursor.lockState = CursorLockMode.None;
		}
	}
}