using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMgr : MonoBehaviour
{
    public static CameraMgr inst;
    private void Awake()
    {
        inst = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject RTSCameraRig;
    public GameObject YawNode;   // Child of RTSCameraRig
    public GameObject PitchNode; // Child of YawNode
    public GameObject RollNode;  // Child of PitchNode
    //Camera is child of RollNode

    public float cameraMoveSpeed = 50;
    public float cameraTurnRate = 10;
    public Vector3 currentYawEulerAngles = Vector3.zero;
    public Vector3 currentPitchEulerAngles = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        // Center the Camera Back to Original Location
        if (Input.GetKey(KeyCode.F))
        {
            //YawNode.transform.Translate(Vector3.zero);
            //YawNode.transform.localPosition = Vector3.zero;
            //YawNode.transform.localEulerAngles = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.W))
            YawNode.transform.Translate(Vector3.forward * Time.deltaTime * cameraMoveSpeed);
        if (Input.GetKey(KeyCode.S))
            YawNode.transform.Translate(Vector3.back * Time.deltaTime * cameraMoveSpeed);
        if (Input.GetKey(KeyCode.A))
            YawNode.transform.Translate(Vector3.left * Time.deltaTime * cameraMoveSpeed);
        if (Input.GetKey(KeyCode.D))
            YawNode.transform.Translate(Vector3.right * Time.deltaTime * cameraMoveSpeed);
       
        currentYawEulerAngles = YawNode.transform.localEulerAngles;
        if (Input.GetKey(KeyCode.Q))
            currentYawEulerAngles.y -= cameraTurnRate * Time.deltaTime;
        if (Input.GetKey(KeyCode.E))
            currentYawEulerAngles.y += cameraTurnRate * Time.deltaTime;
        YawNode.transform.localEulerAngles = currentYawEulerAngles;

        currentPitchEulerAngles = PitchNode.transform.localEulerAngles;
        if (Input.GetKey(KeyCode.Z))
            currentPitchEulerAngles.x -= cameraTurnRate * Time.deltaTime;
        if (Input.GetKey(KeyCode.X))
            currentPitchEulerAngles.x += cameraTurnRate * Time.deltaTime;
        PitchNode.transform.localEulerAngles = currentPitchEulerAngles;

        // Change Camera Perspective
        if (Input.GetKeyUp(KeyCode.C))
        {
            if (isRTSMode)
            {
                YawNode.transform.SetParent(Vehicle.inst.cameraRig.transform);
                YawNode.transform.localPosition = Vector3.zero;
                YawNode.transform.localEulerAngles = Vector3.zero;
            }
            else
            {
                YawNode.transform.SetParent(RTSCameraRig.transform);
                YawNode.transform.localPosition = Vector3.zero;
                YawNode.transform.localEulerAngles = Vector3.zero;
            }
            isRTSMode = !isRTSMode;
        }
    }
    public bool isRTSMode = true;
}
