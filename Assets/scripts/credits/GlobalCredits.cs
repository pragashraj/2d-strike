using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCredits : MonoBehaviour
{
    public int gemCount = 0;
    public int cherryCount = 0;
    public float score = 0;

    public Text gemScore;
    public Text cherryScore;

    public GameObject player;
    private PlayerHealth playerHealth;

    public bool canIncrease = true;

    private void Start()
    {
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    void Update()
    {
        gemScore.text = (gemCount * 10).ToString();
        cherryScore.text = (cherryCount * 10) .ToString();

        if(gemCount!=0 && cherryCount != 0)
        {
            if (gemCount % 5 == 0 || cherryCount % 5 == 0)
            {
                if (canIncrease)
                {
                    playerHealth.increaseHealth(8);
                    canIncrease = false;
                }

            }
            else
            {
                canIncrease = true;
            }
        }
       
    }
}
