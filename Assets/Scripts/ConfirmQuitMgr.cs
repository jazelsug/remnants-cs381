using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmQuitMgr : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject ConfirmQuitPanel;

    // Start is called before the first frame update
    void Start()
    {
        ConfirmQuitPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayConfirmPanel()
    {
        PausePanel.SetActive(false);
        ConfirmQuitPanel.SetActive(true);
    }

    public void ConfirmBackToPause()
    {
        ConfirmQuitPanel.SetActive(false);
        PausePanel.SetActive(true);
    }
}
