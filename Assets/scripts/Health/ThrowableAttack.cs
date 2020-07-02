using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableAttack : MonoBehaviour
{
    public GameObject player;
    private PlayerHealth playerHealth;
    public float rotateSpeed;

    private void Start()
    {
        playerHealth = player.GetComponent<PlayerHealth>();    
    }

    private void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, rotateSpeed));
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerHealth.reduceHealth(5);
        }
    }
}
