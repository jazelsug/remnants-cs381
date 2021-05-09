using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devil : Entity
{
    public static Devil inst;

    private void Awake()
    {
        inst = this;
    }

    public GameObject monster, fragment;
    public int xPos, zPos;
    public static int monsterCount, monsterDeathCount;

    private static readonly int MAX_SPAWN_RATE = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DetermineSpawnArea()
    {
        //Location 1
        xPos = Random.Range(400, 508);      // random number from 400 to 508
        zPos = Random.Range(484, 500);      // random number from 484 to 499

        // Location 2
        xPos = Random.Range(357, 401);      // random number from 357 to 400
        zPos = Random.Range(444, 539);      // random number from 444 to 538

        // Location 3
        xPos = Random.Range(312, 358);      // random number from 312 to 357
        zPos = Random.Range(464, 539);      // random number from 464 to 538

        // Location 4
        xPos = Random.Range(503, 516);      // random number from 503 to 515
        zPos = Random.Range(469, 547);      // random number from 469 to 546
    }

    public IEnumerator InitialSpawn()
    {
        for (int i = 0; i < MAX_SPAWN_RATE; i++)
        {
            xPos = Random.Range(373, 389);      // random number from 357 to 400
            zPos = Random.Range(365, 414);      // random number from 444 to 538

            Instantiate(monster, new Vector3(xPos, 0.32f, zPos), Quaternion.identity); // orig. y = 10.28f
            yield return new WaitForSeconds(0.1f);

            monsterCount++;
        }

        Debug.Log("MonsterCount: " + monsterCount);
    }

    public void SpawnMonsters()
    {
        for (int i = 0; i < MAX_SPAWN_RATE; i++)
        {
            xPos = Random.Range(373, 389);      // random number from 357 to 400
            zPos = Random.Range(365, 414);      // random number from 444 to 538

            Instantiate(monster, new Vector3(xPos, 0.32f, zPos), Quaternion.identity); // orig. y = 10.28f

            monsterCount++;
        }

        Debug.Log("MonsterCount: " + monsterCount);
    }
}
