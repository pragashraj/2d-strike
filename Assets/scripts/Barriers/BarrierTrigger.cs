using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierTrigger : MonoBehaviour
{
    public GameObject player;
    private PlayerAnimationControl animationControl;
    private PlayerHealth playerHealth;

    public float backForce=-1f;

    void Start()
    {
        animationControl = player.GetComponent<PlayerAnimationControl>();
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animationControl.hurtAnimation();
            player.transform.Translate(new Vector3(backForce, 0, 0));
            playerHealth.reduceHealth();
        }
    }
}
