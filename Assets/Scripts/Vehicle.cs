using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : Entity
{
    public static Vehicle inst;
    private void Awake()
    {
        inst = this;
    }

    public GameObject cameraRig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
