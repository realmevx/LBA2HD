using UnityEngine;
using System.Collections;

public class MovingSkybox : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	float rot;
	// Update is called once per frame
	void Update () {

		rot += 0.2f * Time.deltaTime;
		rot %= 360;

		RenderSettings.skybox.SetFloat("_Rotation",rot);

	}
}
