using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followObject;
    public float x;
    void Start()
    {
        x = followObject.position.x;
    }

    void Update()
    {
        x = followObject.position.x;
        gameObject.transform.position = new Vector3(x+5f, 0, -10);
    }
}
