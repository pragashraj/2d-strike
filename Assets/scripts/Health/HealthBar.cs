using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image bar;
    public float fillingAmount = 100;
    public float lerpSpeed = 2;


    void Update()
    {
        handleBar();
    }


    public void handleBar()
    {
        float amount = map(fillingAmount);
        bar.fillAmount = Mathf.Lerp(bar.fillAmount, amount, Time.deltaTime * lerpSpeed);
    }

    public float map(float value)
    {
        return value / 100;
    }

}
