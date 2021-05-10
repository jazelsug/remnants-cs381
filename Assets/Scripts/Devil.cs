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

    private readonly int MAX_SPAWN_RATE = 10;
    private readonly int NUM_OF_DIMS = 6;
    private int[,] xRanges;
    private int[,] zRanges;

    // Start is called before the first frame update
    void Start()
    {
        xRanges = new int[NUM_OF_DIMS, 2];
        zRanges = new int[NUM_OF_DIMS, 2];

        xRanges[0, 0] = 392; xRanges[0, 1] = 400;
        zRanges[0, 0] = 365; zRanges[0, 1] = 471;

        xRanges[1, 0] = 360; xRanges[1, 1] = 397;
        zRanges[1, 0] = 380; zRanges[1, 1] = 412;

        xRanges[2, 0] = 312; xRanges[2, 1] = 513;
        zRanges[2, 0] = 422; zRanges[2, 1] = 431;

        xRanges[3, 0] = 508; xRanges[3, 1] = 516;
        zRanges[3, 0] = 403; zRanges[3, 1] = 477;

        xRanges[4, 0] = 312; xRanges[4, 1] = 430;
        zRanges[4, 0] = 392; zRanges[4, 1] = 400;

        xRanges[5, 0] = 310; xRanges[5, 1] = 323;
        zRanges[5, 0] = 421; zRanges[5, 1] = 471;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator InitialSpawn()
    {
        for (int i = 0; i < MAX_SPAWN_RATE; i++)
        {
            int j = Random.Range(0, NUM_OF_DIMS); // Pick Random Range for Spawning

            xPos = Random.Range(xRanges[j, 0], xRanges[j, 1]);
            zPos = Random.Range(zRanges[j, 0], zRanges[j, 1]);

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
