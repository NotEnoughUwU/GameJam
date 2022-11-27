using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Car : MonoBehaviour
{
    bool hitCheck;
    public EventManager eventManager;
    public Rigidbody rb;

    public Animator animator;

    public AudioSource Crash1;
    public AudioSource Crash2;
    public AudioSource Walking;
    public PlayableDirector timeline;

    // Start is called before the first frame update
    void Start()
    {
        timeline.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (!hitCheck && other.relativeVelocity.magnitude > 10)
        {
            hitCheck = true;
            eventManager.score++;
            Debug.Log(eventManager.score);
            animator.enabled = false;
            timeline.Stop();
            Crash1.Play(0);
            Crash2.Play(0);
            Walking.Play(0);
        }
    }
}
