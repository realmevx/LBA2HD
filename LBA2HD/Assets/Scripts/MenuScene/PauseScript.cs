using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;

	// Use this for initialization
	void Start () {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
	}

    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        SceneManager.LoadScene("scene1");
    }

	public void StartNight()
	{
		float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
		SceneManager.LoadScene("scene2");
	}

	public void DesertDay()
	{
		float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
		SceneManager.LoadScene("DesertDay");
	}
	public void DesertNight()
	{
		float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
		SceneManager.LoadScene("DesertNight");
	}
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
