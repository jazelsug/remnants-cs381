using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMgr : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject GametimePanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!PausePanel.activeSelf && Input.GetKeyUp(KeyCode.P))
        {
            //P is pressed and Pause Panel is inactive
            Timer.inst.timerIsRunning = false;  //pause the timer
            Time.timeScale = 0; //freeze objects that depend on Time
            GametimePanel.SetActive(false); //deactivate the Gametime Panel
            PausePanel.SetActive(true);
        }
        else if(PausePanel.activeSelf && Input.GetKeyUp(KeyCode.P))
        {
            //P is pressed and Pause Panel is active
            PausePanel.SetActive(false);
            Time.timeScale = 1;
            Timer.inst.timerIsRunning = true;
            GametimePanel.SetActive(true);
        }
    }
}
