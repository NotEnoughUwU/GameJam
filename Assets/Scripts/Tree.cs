using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    bool hitCheck;
    public EventManager eventManager;
    public Rigidbody rb;
    public AudioSource Break;

    // Start is called before the first frame update
    void Start()
    {
        hitCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (!hitCheck && other.relativeVelocity.magnitude > 5)
        {
            hitCheck = true;
            eventManager.score++;
            Debug.Log(eventManager.score);

            Break.Play(0);
        }
    }
}
