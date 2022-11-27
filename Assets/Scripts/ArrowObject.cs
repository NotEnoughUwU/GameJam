using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowObject : MonoBehaviour
{
    public Transform LookAtObj;
    public Transform Ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(LookAtObj);
        transform.eulerAngles += new Vector3(-90, 0, 180);
        transform.position = Ball.position;
    }
}
