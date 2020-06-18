using System.Collections;
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

    public float horizontalMoveCondition=2;
    public float verticalMoveCondition = 2;

    void Start()
    {
        animationControl = gameObject.GetComponent<PlayerAnimationControl>();
       // gameObject.transform.localScale = new Vector3(10, 10, 0);
        //gameObject.transform.localPosition = new Vector3(0, 0, 0);
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
            animationControl.runAnimation(true);
            gameObject.transform.Translate(new Vector3(horizontalMove, 0, 0));
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
            animationControl.jumpAnimation();
            gameObject.transform.Translate(new Vector3(0, verticalMove, 0));
        }
        else if(verticalMove <= -verticalMoveCondition)
        {
            animationControl.crounchAnimation(true);
        }
        else
        {
            animationControl.crounchAnimation(false);
        }
    }

   
}
