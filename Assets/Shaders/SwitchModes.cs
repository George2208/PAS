using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchModes : MonoBehaviour
{
    public RawImage lightOn, lightOff;
    public static bool onLightState = false;

    public void Start()
    {
        this.changeLight();
    }

    public void OnLight()
    {
        onLightState = true;
        this.changeLight();
    }

    public void OffLight()
    {
        onLightState = false;
        this.changeLight();
    }

    public void changeLight()
    {
        if (onLightState) 
        {
            this.lightOff.gameObject.SetActive(true);
            this.lightOn.gameObject.SetActive(false);
        } 
        else {
            this.lightOff.gameObject.SetActive(false);
            this.lightOn.gameObject.SetActive(true);
        }
    }
}
