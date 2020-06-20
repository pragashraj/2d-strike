using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierTrigger : MonoBehaviour
{
    public GameObject player;
    private PlayerAnimationControl animationControl;
    public float backForce=-1f;

    void Start()
    {
        animationControl = player.GetComponent<PlayerAnimationControl>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animationControl.hurtAnimation();
            player.transform.Translate(new Vector3(backForce, 0, 0));
        }
    }
}
