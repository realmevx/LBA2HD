using UnityEngine;
using UnityEngine.UI;


public class IntroTextAppearScript : MonoBehaviour
{
    static bool introTextAlreadyShown = false;

    public Text canvasText1;
    public Text canvasText2;
    public Text canvasText3;
    public float textduration;

    void Start()
    {
        // As soon as this function is called, call the bottom functions 'ShowTextY' after xxf seconds.


        Invoke("HideAllTexts", 0f);                         //invoke at the beginning
        if (introTextAlreadyShown == false){

            introTextAlreadyShown = true;
            Invoke("ShowText1",    2f);                     //invoke after  2 seconds
            Invoke("ShowText2",    2f + 1 * textduration);  //invoke after 10 seconds
            Invoke("ShowText3",    2f + 2 * textduration);  //invoke after 18 seconds
            Invoke("HideAllTexts", 2f + 3 * textduration);  //invoke after 26 seconds
        }
    }


    void ShowText1()
    {
        canvasText1.enabled =  true;
        canvasText2.enabled = false;
        canvasText3.enabled = false;
    }

    void ShowText2()
    {
        canvasText1.enabled = false;
        canvasText2.enabled = true;
        canvasText3.enabled = false;
    }

    void ShowText3()
    {
        canvasText1.enabled = false;
        canvasText2.enabled = false;
        canvasText3.enabled = true;
    }

    void HideAllTexts()
    {
        canvasText1.enabled = false;
        canvasText2.enabled = false;
        canvasText3.enabled = false;
    }
}