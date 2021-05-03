using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static public Timer inst;

    private void Awake()
    {
        inst = this;
    }

    public bool timerIsRunning = false;
    public float timeRemaining = 60;    //60 seconds

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning && timeRemaining > 0)
        {
            //decrement timer
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            //timer ran out
            timeRemaining = 0;
            timerIsRunning = false;
            Time.timeScale = 0; //freeze game objects TEST
            GameOverPanelDisplay.inst.gameObject.SetActive(true);
            //otherObject.GetComponent<NameOfScript>().enabled = false;
        }
        //update timeText
        DisplayTime(timeRemaining);
    }

    public Text timeText;

    void DisplayTime(float timeToDisplay)
    {
        //calculate minutes, seconds, and milliSeconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;

        //update timeText - only display minutes if more than 59 seconds is left in the timer
        if (minutes != 0)
        {
            timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);
        }
        else
        {
            timeText.text = string.Format("{0:00}:{1:000}", seconds, milliSeconds);
        }
    }
}
