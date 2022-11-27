using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour
{
    public Transform LaunchDirection;
    public Rigidbody self;
    public Transform LookAtObj;

    public float launchForce;

    Vector3 Direction;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Launch();
    }

    void Launch()
    {
        Direction = LookAtObj.transform.position - transform.position;
        Direction = Direction.normalized;

        self.AddForce(Direction * launchForce);
    }
}