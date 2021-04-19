using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMgr : MonoBehaviour
{
    public static ControlMgr inst;
    private void Awake()
    {
        inst = this;
    }

    public Vehicle selectedEntity;

    // Start is called before the first frame update
    void Start()
    {

    }

    public float deltaSpeed = 1;
    public float deltaHeading = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
            selectedEntity.desiredSpeed += deltaSpeed;
        if (Input.GetKeyUp(KeyCode.DownArrow))
            inst.selectedEntity.desiredSpeed -= deltaSpeed;
        selectedEntity.desiredSpeed =
            Utils.Clamp(selectedEntity.desiredSpeed, selectedEntity.minSpeed, selectedEntity.maxSpeed);

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            selectedEntity.desiredHeading -= deltaHeading;
        if (Input.GetKeyUp(KeyCode.RightArrow))
            selectedEntity.desiredHeading += deltaHeading;
        inst.selectedEntity.desiredHeading = Utils.Degrees360(selectedEntity.desiredHeading);

    }
}
