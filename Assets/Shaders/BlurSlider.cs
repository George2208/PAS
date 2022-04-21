using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlurSlider : MonoBehaviour
{
    public static float blurSizeValue;
    [SerializeField]
    Slider blurSize;

    public void onBlurChange(float value) 
    {
        blurSizeValue = value;
    }
}
