using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Particles : MonoBehaviour
{
    void OnDestroy()
    {
        SceneManager.LoadScene(0);
    }
    
}
