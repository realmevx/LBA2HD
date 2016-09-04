using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour {

    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;

    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDirection = -1; // in = -1     and     out = 1

    void OnGUI()
    {
        alpha += fadeDirection * fadeSpeed * Time.deltaTime; 
        
        // force (clamp) the number between 0 and 1 because GUI.color uses alpha values between 0 and 1
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    // sets fadeDirection to the direction parameter making the scene fade in if -1 and out if 1
    public float BeginFade (int direction)
    {
        fadeDirection = direction;

        if (fadeSpeed != 0)
        { return (1 / fadeSpeed ); }

        else
        { return 0; }
    }

    //OnLevelWasLoaded is called when a level is loaded. It takes loaded level index (int) as a parameter so you can limit the fade in to certain scenes
    void OnLevelWasLoaded()
    {
        //alpha = -1
        BeginFade(-1);
    }
}
