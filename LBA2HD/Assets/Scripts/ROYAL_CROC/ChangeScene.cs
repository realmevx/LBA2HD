using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public float timePicture = 2.8f;

	void Start () {

        Invoke("ChangeScenes", timePicture);
	}

    void ChangeScenes()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        SceneManager.LoadScene("MenuScene");
    }
}
