﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private PlayerAnimationControl animationControl;
    public Joystick joystick;

    public float runSpeed = 0.1f;
    public float jumplength = 0.1f;
    public float horizontalMove = 0;
    public float verticalMove = 0;
    public float crounchhorizontalMove = 0;

    public float horizontalMoveCondition=2;
    public float verticalMoveCondition = 2;

    void Start()
    {
        animationControl = gameObject.GetComponent<PlayerAnimationControl>();
    }


    void Update()
    {
        horizontalMove = joystick.Horizontal * runSpeed;
        verticalMove = joystick.Vertical * jumplength;

        run(horizontalMove);
        jumpOrCrounch(verticalMove);
    }


    void run(float horizontalMove)
    {
        if (horizontalMove >= horizontalMoveCondition)
        {
            animationControl.runAnimation(true);
            gameObject.transform.Translate(new Vector3(horizontalMove, 0, 0));
        }else if (horizontalMove <= -horizontalMoveCondition)
        {
           // animationControl.runAnimation(true);
            //gameObject.transform.Translate(new Vector3(horizontalMove, 0, 0));
        }
        else
        {
            animationControl.runAnimation(false);
        }
    }

    void jumpOrCrounch(float verticalMove)
    {
        if (verticalMove >= verticalMoveCondition)
        {
            //animationControl.jumpAnimation();
            gameObject.transform.Translate(new Vector3(0, verticalMove, 0));
        }
        else if(verticalMove <= -verticalMoveCondition)
        {
            animationControl.crounchAnimation(true);
            gameObject.transform.Translate(new Vector3(crounchhorizontalMove, 0, 0));
            gameObject.GetComponent<CircleCollider2D>().radius = 0.01f;
        }
        else
        {
            animationControl.crounchAnimation(false);
            gameObject.GetComponent<CircleCollider2D>().radius = 0.12f;
        }
    }

   
}
