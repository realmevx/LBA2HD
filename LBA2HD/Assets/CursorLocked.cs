using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLocked : MonoBehaviour {

	// Use this for initialization
	bool CursorLockedVar;

	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		CursorLockedVar = (true);
	}

	void Update ()
	{
		if (Input.GetKeyDown ("escape") && !CursorLockedVar) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = (false);
			CursorLockedVar = (true);
		}
		else if(Input.GetKeyDown("escape") && CursorLockedVar){
			Cursor.lockState = CursorLockMode.Confined;
			Cursor.visible = (true);
			CursorLockedVar = (false);
		}
	}
}