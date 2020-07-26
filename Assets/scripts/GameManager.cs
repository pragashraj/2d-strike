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

    void Start()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
        PlayerMovement = player.GetComponent<playerMovement>();
    }

    void Update()
    {
        if (playerHealth.health <= 0)
        {
            gameOver.SetActive(true);
            PlayerMovement.enabled = false;
            Time.timeScale = 0;
        }
    }


    public void pauseGame()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
    }


    public void resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
