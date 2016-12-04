#pragma strict

function Start () {
	GameObject.Find("FPSController").SetActive(false);
}

function Update () {
	if (Input.GetKeyDown(KeyCode.N));
	GameObject.Find("FPSController").SetActive(false);

}
