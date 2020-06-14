using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private PlayerAnimationControl animationControl;
    public Joystick joystick;

    public float runSpeed = 1;
    float horizontalMove = 0;

    void Start()
    {
        animationControl = gameObject.GetComponent<PlayerAnimationControl>();
    }


    void Update()
    {
        horizontalMove = joystick.Horizontal * runSpeed;
        gameObject.transform.Translate(new Vector3(horizontalMove, 0, 0));
    }
}
