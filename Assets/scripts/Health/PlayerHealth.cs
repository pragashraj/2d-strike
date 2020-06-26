using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public GameObject healthBarObject;
    private HealthBar healthBar;
    public bool death = false;


    void Start()
    {
        healthBar = healthBarObject.GetComponent<HealthBar>();
    }


    public void reduceHealth(float healthLoss)
    {
        if (health > 0)
        {
            health -= healthLoss;
            health = Mathf.Clamp(health, 0, 100);
            healthBar.fillingAmount = health;
        }
    }

    public void increaseHealth(float healthGain)
    {
        if (health < 100)
        {
            health += healthGain;
            health = Mathf.Clamp(health, 0, 100);
            healthBar.fillingAmount = health;
        }
       
    }

}