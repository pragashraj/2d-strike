using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumControl : MonoBehaviour
{
    public float runningSpeed = -0.4f;

    void Start()
    {
        
    }

    void Update()
    {
        run();
    }


    void run()
    {
        gameObject.transform.Translate(new Vector3(runningSpeed*Time.deltaTime, 0, 0));
    }

}
