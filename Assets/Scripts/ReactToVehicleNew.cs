using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactToVehicleNew : MonoBehaviour
{
    public GameObject vehicle;
    public Animator anim;
    public GameObject devil;
    public float dist;
    public float distanceToReact = 10.0f;

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
        }
    }
}
