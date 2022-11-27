using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public float grav;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, grav, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}