using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform LookAtTarget;
    public int rotateSpeed;
    
    bool rotateUp, rotateDown, rotateLeft, rotateRight;

    void Start()
    {
        rotateLeft = false;
        rotateRight = false;
    }

    void Update()
    {
        transform.LookAt(LookAtTarget);

        if (Input.GetKeyDown("a"))
            rotateLeft = true;
        else if (Input.GetKeyUp("a"))
            rotateLeft = false;
        if (Input.GetKeyDown("d"))
            rotateRight = true;
        else if (Input.GetKeyUp("d"))
            rotateRight = false;
    }

    void FixedUpdate()
    {
        if (rotateLeft)
        {
            transform.RotateAround(LookAtTarget.transform.position, Vector3.up, -rotateSpeed);
        }
        if (rotateRight)
        {
            transform.RotateAround(LookAtTarget.transform.position, Vector3.up, rotateSpeed);
        }
    }
}
