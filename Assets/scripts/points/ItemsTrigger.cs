using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsTrigger : MonoBehaviour
{
    string Owntag;
    void Start()
    {
        Owntag = gameObject.tag;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (Owntag)
            {
                case "gem":
                    print(tag);
                    break;

                default: break;
            }
        }
    }
}
