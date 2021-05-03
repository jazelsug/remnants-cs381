using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleVehicleMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform car;
    public float speed = 17;


    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(backward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
        }

    }
}
