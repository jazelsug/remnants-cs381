using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactToVehicle : MonoBehaviour
{
    public GameObject vehicle;
    Animator anim;
    public float dist;
    public GameObject devil;
    public Animation a;
    public float distanceToReact = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = devil.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(vehicle.transform.position, devil.transform.position);
        if (dist < distanceToReact)
        {
            anim.ResetTrigger("Idle");
            anim.SetTrigger("Fly");
            a.Stop("devil@idle");
            a.Play("devil@fly");
        }
    }
}
