using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCamera : MonoBehaviour
{
    public GameObject cam;
    private CameraFollow cameraFollow;

    public void Start()
    {
        cameraFollow = cam.GetComponent<CameraFollow>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cameraFollow.canFollow = false;
        }
    }
}
