using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class BlurShaderScript : MonoBehaviour
{
    public Material blurMat;
    public float mini = 1f, maxi = 1.6f, changePerSecond = 0.4f;

    float lum, blur, vigOn = 0;
    int direction = 2;
    
    BlurShaderScript() {
        lum = (mini + maxi) / 2;
    }

    public void Update () 
    {
        if (SwitchModes.onLightState) 
        {
            if (direction == 1 && lum - changePerSecond * Time.deltaTime >= mini) 
                lum -= changePerSecond * Time.deltaTime;
            else direction = 2;
            if(direction == 2 && lum + changePerSecond * Time.deltaTime <= maxi) 
                lum += changePerSecond * Time.deltaTime;
            else direction = 1;
        }
        if (BlurSlider.blurSizeValue != 0)
            blur = BlurSlider.blurSizeValue;
        else blur = 0;

        if (SwitchModesVig.onVignetteState)
            vigOn = 1;
        else vigOn = 0;
    }

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        blurMat.SetFloat("_BlurSize", blur);
        blurMat.SetFloat("_Glow", lum);
        blurMat.SetFloat("_vigOn", vigOn);
		Graphics.Blit(source, destination, blurMat);
    }
}
