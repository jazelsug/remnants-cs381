using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollowPlayer : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float dist;
    public float distanceToReact = 10.0f;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Devils will start flying (moving towards Vehicle??) if Vehicle is at a close enough distance.
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist < distanceToReact)
        {
            // enemy will now only follow if the boolean enemyShouldFollow is true
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
    }

    void OnCollisionEnter(Collision col)
    {
        // change player name for the name of your players game object
        if (col.gameObject.name == "Car")
        {
            Destroy(gameObject);
        }
    }
}
