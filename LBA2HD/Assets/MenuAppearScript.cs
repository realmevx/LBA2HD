using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class MenuAppearScript : MonoBehaviour {

	public GameObject menu; // Assign in inspector
	private bool isShowing;
	void start() {
		
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			isShowing = !isShowing;
			menu.SetActive(isShowing);

			Time.timeScale = isShowing ? 0 : 1;
		}
	}
}