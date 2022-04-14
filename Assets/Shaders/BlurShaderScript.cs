using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BlurShaderScript : MonoBehaviour
{
    public Material blurMat;

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, blurMat);
    }
}
