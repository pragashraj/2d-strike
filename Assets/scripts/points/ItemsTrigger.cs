using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsTrigger : MonoBehaviour
{
    string Owntag;
    public GameObject GlobalCreditOb;
    private GlobalCredits globalCredits;
    private Animator animator;

    void Start()
    {
        Owntag = gameObject.tag;
        globalCredits = GlobalCreditOb.GetComponent<GlobalCredits>();
        animator = gameObject.GetComponent<Animator>();
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
                    animator.SetTrigger("item-feed");
                    StartCoroutine(setGameObjectActivation());
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


    IEnumerator setGameObjectActivation()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }



}
