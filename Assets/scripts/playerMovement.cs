using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private PlayerAnimationControl animationControl;
    public Joystick joystick;

    public float runSpeed = 1;
    public float horizontalMove = 0;
    public float verticalMove = 0;

    void Start()
    {
        animationControl = gameObject.GetComponent<PlayerAnimationControl>();
    }


    void Update()
    {
        horizontalMove = joystick.Horizontal * runSpeed;
        verticalMove = joystick.Vertical * runSpeed;

        run(horizontalMove);
        jumpOrCrounch(verticalMove);
    }


    void run(float horizontalMove)
    {
        if (horizontalMove >= 0.02f)
        {
            animationControl.runAnimation(true);
            gameObject.transform.Translate(new Vector3(horizontalMove, 0, 0));
        }else if (horizontalMove <= -0.02f)
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
        if (verticalMove >= 0.02f)
        {
            animationControl.jumpAnimation();
            gameObject.transform.Translate(new Vector3(0, verticalMove, 0));
        }
        else if(verticalMove <= -0.02f)
        {
            animationControl.crounchAnimation(true);
        }
        else
        {
            animationControl.crounchAnimation(false);
        }
    }

   
}
