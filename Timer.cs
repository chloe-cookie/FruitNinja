using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeRemaining = 60f;
    public Text TimeOutput;

    bool TimeEnded = false;
    float timeRemaining;

    private void OnEnable()
    {
        //we setup the variables for our timer.

        TimeEnded = false;
        timeRemaining = TimeRemaining;
        SetText();//never repeat code. rule #1
    }

    void Update()
    {
        //only count time, if the game hasn't ended
        if (!TimeEnded) //TimeEnded == false
        {
            timeRemaining -= Time.deltaTime;

            SetText();

            if (timeRemaining <= 0)
            {//we want to stop
                TimeEnded = true;
            }
        }
    }

    void SetText()
    {
        var finalTime = Mathf.Floor(timeRemaining);
        TimeOutput.text = finalTime.ToString();
    }
}
