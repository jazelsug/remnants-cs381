using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMgr : MonoBehaviour
{
    public GameObject monster, explosion;
    public int xPos, zPos;
    public int monsterCount, monsterDeathCount;

    public float radius;
    public Collider[] colliders;

    // Makes the monsters follow player
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnMonsters());
        rb = monster.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //rb.rotation = angle;
        //direction.Normalize();
        //movement = direction;
    }

    private void FixedUpdate()
    {
        moveMonster(movement);
    }

    void moveMonster(Vector3 direction)
    {
        rb.MovePosition((Vector3)transform.position + (direction * moveSpeed * Time.deltaTime));
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

            Instantiate(monster, new Vector3(xPos, 0.32f, zPos), Quaternion.identity); // orig. y = 10.28f
            yield return new WaitForSeconds(0.1f);

            monsterCount++;
        }
    }


    /**
    IEnumerator spawnMonsters()
    {
        Vector3 spawnPos = Vector3.zero;
        bool canSpawnHere = false;

        while(monsterCount < 10)
        {
            xPos = Random.Range(311, 517);      // random number from 311 to 516
            zPos = Random.Range(395, 481);      // random number from 395 to 480

            spawnPos = new Vector3(xPos, 0.45f, zPos);
            canSpawnHere = doesObjectOverlap(spawnPos);
            
            if(canSpawnHere)
            {
                Instantiate(monster, spawnPos, Quaternion.identity); // orig. y = 10.28f
                yield return new WaitForSeconds(0.1f);
                monsterCount++;
            }
        }
    }

    bool doesObjectOverlap(Vector3 spawnPos)
    {
        colliders = Physics.OverlapSphere(transform.position, radius);

        for(int i = 0; i < colliders.Length; i++)
        {
            Vector3 centerPoint = colliders[i].bounds.center;
            float xLength = colliders[i].bounds.extents.x;
            float zLength = colliders[i].bounds.extents.z;

            float xPosExtent = centerPoint.z + xLength;
            float xNegExtent = centerPoint.z - xLength;
            float zPosExtent = centerPoint.z + zLength;
            float zNegExtent = centerPoint.z - zLength;

            //Object Overlaps
            if(spawnPos.x <= xPosExtent && spawnPos.x >= xNegExtent)
            {
                if (spawnPos.z <= zPosExtent && spawnPos.z >= zNegExtent)
                {
                    return true;
                }
            }
        }
        return false;
    }
    */
}
