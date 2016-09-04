using UnityEngine;
using System.Collections;

public class IntroLightFade : MonoBehaviour
{

    private float intensityBefore;
    public Light light;
    public int fadeDurationInFrames;
    public int fadeStartsAfterFrames;

    void Start()
    {
        setLight();
        getIntensityBefore();
        changeIntensity();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("changeIntensity",3.0f);
    }

    void setLight()
    {
        if (Time.frameCount > fadeStartsAfterFrames)
        {
            light = gameObject.GetComponent(typeof(Light)) as Light;
        }
    }

    Light getLight()
    {
        return light;
    }


    void getIntensityBefore()
    {
        intensityBefore = getLight().intensity;
        getLight().intensity = 0.0f;
    }

    void changeIntensity()
    {
        int frame = Time.frameCount;
        if (getLight().intensity < intensityBefore)
        {            
            getLight().intensity = frame * (intensityBefore*0.001f);
        }
    }
}
