using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsTrigger : MonoBehaviour
{
    string Owntag;
    public GameObject GlobalCreditOb;
    private GlobalCredits globalCredits;


    void Start()
    {
        Owntag = gameObject.tag;
        globalCredits = GlobalCreditOb.GetComponent<GlobalCredits>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (Owntag)
            {
                case "gem":
                    FindObjectOfType<AudioManager>().Play("diamondCollection");
                    globalCredits.gemCount += 1;
                    gameObject.SetActive(false);
                    break;

                case "cherry":
                    FindObjectOfType<AudioManager>().Play("cherryCollection");
                    globalCredits.cherryCount += 1;
                    gameObject.SetActive(false);
                    break;

                default: break;
            }
        }
    }



}
