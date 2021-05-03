using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollowPlayer : MonoBehaviour
{
    public Animator anim;
    public float speed = 0.05f;
    private Transform target;
    public float dist;
    public float distanceToReact = 10.0f;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Devils will start flying (moving towards Vehicle??) if Vehicle is at a close enough distance.
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist < distanceToReact)
        {
            anim.ResetTrigger("Idle");
            anim.SetTrigger("Fly");
            // enemy will now only follow if the boolean enemyShouldFollow is true
            transform.LookAt(target.position); //With this line the obj rotate
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);  //orig. Vector2

        }
    }

    void OnCollisionEnter(Collision col)
    {
        // change player name for the name of your players game object
        if (col.gameObject.name == "Car")
        {
            //increment kill counter
            MonsterKillCounter.inst.count++;

            //destroy devil
            Destroy(gameObject);
        }
    }
}
