using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMgr : MonoBehaviour
{
    public static AIMgr inst;

    private void Awake()
    {
        inst = new AIMgr();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Devil.inst.InitialSpawn());
    }

    void Update()
    {
        
    }

    public void AddMoreMonsters()
    {
        // Check if we need to spawn more monsters
        if ((Devil.monsterCount - MonsterKillCounter.inst.count) < 4)
        {
            Devil.inst.SpawnMonsters();
            Debug.Log("Spawned more monsters");
        }
    }
}
