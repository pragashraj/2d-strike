using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndTrigger : MonoBehaviour
{
    public GameObject[] UIs;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int i;
            for (i = 0; i <= UIs.Length - 1; i++)
            {
                UIs[i].SetActive(false);
            }
        }
    }
}
