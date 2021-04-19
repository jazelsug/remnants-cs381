using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVehicle : MonoBehaviour
{
    public GameObject vehicle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void Update()
    {
        transform.position = vehicle.transform.position + offset;
    }
}
