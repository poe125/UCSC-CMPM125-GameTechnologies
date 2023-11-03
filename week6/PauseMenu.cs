using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject buttonPause;
    public GameObject buttonResume;

    public bool paused = false;

    // Update is called once per frame
    void Update()
    {
        if (buttonPause)
        {
            paused = true;
        }
        if(buttonResume)
        {
            paused = false;
        }

        if(paused)
        {
            Time.timeScale = 0f;
        } else if (!paused)
        {
            Time.timeScale = 1f;
        }
     }
}
