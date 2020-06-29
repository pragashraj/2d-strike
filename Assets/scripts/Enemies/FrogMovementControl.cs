using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovementControl : MonoBehaviour
{
    private Animator animator;
    public bool canMove = true;
    public float runningSpeed = -0.2f;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        canJump(true);
    }

    void Update()
    {
        if (canMove)
        {
            gameObject.transform.Translate(new Vector3(runningSpeed * Time.deltaTime, 0, 0));
        }
    }

    public void canJump(bool action)
    {
        animator.SetBool("jump",action);
    }
}
