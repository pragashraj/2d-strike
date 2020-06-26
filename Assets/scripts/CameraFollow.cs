using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followObject;
    public float x;
    public bool canFollow = true;

    void Start()
    {
        x = followObject.position.x;
    }

    void Update()
    {
        if (canFollow)
        {
            x = followObject.position.x;
            gameObject.transform.position = new Vector3(x + 5f, 0, -10);
        }
        
    }
}
