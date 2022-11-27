using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scarecrow : MonoBehaviour
{
    bool hitCheck;
    public EventManager eventManager;
    public Rigidbody rb;
    public AudioSource Ahn;
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
        if (!hitCheck && other.relativeVelocity.magnitude > 30)
        {
            hitCheck = true;
            eventManager.score++;
            Debug.Log(eventManager.score);

            Ahn.Play(0);
            Break.Play(0);
        }
    }
}
