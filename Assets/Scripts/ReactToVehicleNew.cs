using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactToVehicleNew : MonoBehaviour
{
    public static ReactToVehicleNew inst;
    private void Awake()
    {
        inst = this;
    }

    //public Entity vehicle;
    public GameObject vehicle;
    public Animator anim;
    public Entity devil;
    public float dist;
    public float distanceToReact = 10.0f;
    //FollowVehicle fv;
    public float moveDelta = 0.05f; //used to be a double
    //Rigidbody devilRB;

    // Start is called before the first frame update
    void Start()
    {
        anim = devil.GetComponent<Animator>();
        //devilRB = devil.GetComponent<Rigidbody>();
    }

    //float step = speed * Time.deltaTime; // calculate distance to move
    //transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    // Update is called once per frame
    void Update()
    {
        // Devils will start flying (moving towards Vehicle??) if Vehicle is at a close enough distance.
        dist = Vector3.Distance(vehicle.transform.position, devil.transform.position);
        if (dist < distanceToReact)
        {
            anim.ResetTrigger("Idle");
            anim.SetTrigger("Fly");
            //fv = new FollowVehicle(devil, vehicle, new Vector3(100, 0, 0));
            Vector3 movement = new Vector3(vehicle.transform.position.x, 0.0f, vehicle.transform.position.z);
            //devilRB.AddForce(movement * devil.maxSpeed);
            //devil.transform.position = new Vector3(devil.transform.position.x, 0.0f, devil.transform.position.z - 0.1f);    //TODO: fix!!!!
            devil.transform.position = Vector3.MoveTowards(devil.transform.position, vehicle.transform.position, moveDelta * Time.deltaTime);
        }
    }
}
