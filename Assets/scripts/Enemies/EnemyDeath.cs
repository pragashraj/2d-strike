﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject player;
    private PlayerHealth playerHealth;
    Animator animator;
    public GameObject throwable;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            animator.SetTrigger("enemy-death");
            playerHealth.increaseHealth(3);
            StartCoroutine(setGameObjectActivation());
            if (gameObject.tag == "eagle")
            {
                throwable.SetActive(false);
            }
        }
    }

    IEnumerator setGameObjectActivation()
    {
        yield return new WaitForSeconds(3.2f);
        gameObject.SetActive(false);
    }

}
