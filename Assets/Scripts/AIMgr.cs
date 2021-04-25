using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMgr : MonoBehaviour
{
    public GameObject monster, explosion;
    public int xPos, zPos;
    public int monsterCount, monsterDeathCount;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnMonsters());
    }
    
    void determineSpawnArea()
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

    IEnumerator spawnMonsters()
    {
        while(monsterCount < 10)
        {
            xPos = Random.Range(357, 401);      // random number from 357 to 400
            zPos = Random.Range(444, 539);      // random number from 444 to 538

            Instantiate(monster, new Vector3(xPos, 70.28f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);

            monsterCount++;
        }
    }
}
