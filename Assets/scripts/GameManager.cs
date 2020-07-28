using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    private PlayerHealth playerHealth;
    public GameObject gameOver;
    private playerMovement PlayerMovement;
    public GameObject pause;

    public bool gameEnd = false;

    void Start()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        PlayerMovement = player.GetComponent<playerMovement>();
        Time.timeScale = 1;
    }

    void Update()
    {
        if (playerHealth.health <= 0)
        {
            gameOver.SetActive(true);
            PlayerMovement.enabled = false;
            Time.timeScale = 0;
            gameEnd = true;
        }
    }


    public void pauseGame()
    {
        if (playerHealth.health > 0 && !gameEnd)
        {
            pause.SetActive(true);
            Time.timeScale = 0;
        }
    }


    public void resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
