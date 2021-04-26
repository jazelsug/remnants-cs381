using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterKillCounter : MonoBehaviour
{
    public static MonsterKillCounter inst;
    private void Awake()
    {
        inst = this;
    }

    public int count = 0;   //static?
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = "Kills:" + System.Environment.NewLine + count.ToString();
    }
}
