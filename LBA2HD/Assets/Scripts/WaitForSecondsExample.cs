using UnityEngine;
using System.Collections;

public class WaitForSecondsExample : MonoBehaviour {

	void Start() {
		StartCoroutine(Example());
	}

	IEnumerator Example() {
		print(Time.time);
		yield return new WaitForSeconds(5);
		print(Time.time);
	}

}