using UnityEngine;
using UnityEngine.UI;

public class IntroTextScript : MonoBehaviour {

    public Text canvasText1;

	void Start () {
        Invoke("ShowIntroText", 0f);
        Invoke("HideIntroText", 6f);
	}

    void ShowIntroText()
    {
        canvasText1.enabled = true;
    }

    void HideIntroText()
    {
        canvasText1.enabled = false;
    }
	
}
