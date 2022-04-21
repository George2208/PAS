using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedGame : MonoBehaviour
{
    public static bool pause = false;
    public GameObject putPause;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if (pause) 
                onResume();
            else 
                onPause();
        }
    }

    public void onResume() 
    {
        putPause.SetActive(false);
        Time.timeScale = 1f;
        pause = false;
    }

    public void onPause() 
    {
        putPause.SetActive(true);
        Time.timeScale = 0f;
        pause = true;
    }

    public void LoadMenu() 
    { 
        SceneManager.LoadScene(0);
    }
}
