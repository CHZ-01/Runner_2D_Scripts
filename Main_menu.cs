using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    //start game
    public void play()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    //quit game
    public void quit()
    {
        Application.Quit();
    }
}
