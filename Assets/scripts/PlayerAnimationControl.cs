using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControl : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();   
    }

    public void runAnimation(bool action)
    {
        animator.SetBool("run", action);
    }

    public void crounchAnimation(bool action)
    {
        animator.SetBool("crounch", action);
    }

    public void climbAnimation(bool action)
    {
        animator.SetBool("climb", action);
    }

    public void jumpAnimation()
    {
        animator.SetTrigger("jump");
    }

    public void hurtAnimation()
    {
        animator.SetTrigger("hurt");
    }

}
