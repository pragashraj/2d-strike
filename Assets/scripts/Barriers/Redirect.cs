using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirect : MonoBehaviour
{
    public GameObject redirectingObj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        redirectingObj.transform.Rotate(new Vector3(0, 180, 0));
    }
}
