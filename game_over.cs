using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_over : MonoBehaviour
{
    public GameObject over_page;

    //game reload function
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //gameover screen calling
    public void over()
    {
        over_page.SetActive(true);
    }

    //Home screen function
    public void home()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

    //quit game function
    public void quit()
    {
        Application.Quit();
    }
}
