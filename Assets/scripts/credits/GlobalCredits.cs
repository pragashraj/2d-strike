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

    void Update()
    {
        gemScore.text = (gemCount * 10).ToString();
        cherryScore.text = (cherryCount * 10) .ToString();
    }
}
