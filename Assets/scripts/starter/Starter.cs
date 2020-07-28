using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Starter : MonoBehaviour
{
    public GameObject pauseMenu;

    public void play()
    {
       SceneManager.LoadScene(1);   
    }

    public void quit()
    {
        Application.Quit();
    }

    public void resume()
    {
        pauseMenu.SetActive(false);
    }


    public void backToStarter()
    {
        SceneManager.LoadScene(0);
    }
}
