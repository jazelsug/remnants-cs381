using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMgr : MonoBehaviour
{
    public static QuitMgr inst;
    private void Awake()
    {
        inst = this;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            Application.Quit();
    }
}
