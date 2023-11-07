//reference https://www.youtube.com/watch?v=pcyiub1hz20

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    //Start Play and go to interval
   public void Play()
    {
        SceneManager.LoadScene(1);
    }

    //Quit the game
    public void QuitGame()
    {
        Debug.Log("Player Exit Game");
        Application.Quit();
    }

    public void Credits()
    {
        Debug.Log("is in Credit");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene(0);
    }

}
