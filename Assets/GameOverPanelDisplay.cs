using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanelDisplay : MonoBehaviour
{
    static public GameOverPanelDisplay inst;

    private void Awake()
    {
        inst = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Timer.inst.timerIsRunning)
        {
            this.gameObject.SetActive(true);
        }
    }
}
