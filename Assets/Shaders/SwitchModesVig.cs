using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchModesVig : MonoBehaviour
{
    public RawImage vignetteOn, vignetteOff;
    public static bool onVignetteState = false;

    public void Start()
    {
        this.changeVignette();
    }

    public void OnLight()
    {
        onVignetteState = true;
        this.changeVignette();
    }

    public void OffLight()
    {
        onVignetteState = false;
        this.changeVignette();
    }

    public void changeVignette()
    {
        if (onVignetteState) 
        {
            this.vignetteOff.gameObject.SetActive(true);
            this.vignetteOn.gameObject.SetActive(false);
        } 
        else {
            this.vignetteOff.gameObject.SetActive(false);
            this.vignetteOn.gameObject.SetActive(true);
        }
    }
}
