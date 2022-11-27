using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    bool hitCheck;
    public EventManager eventManager;
    public Rigidbody rb;
    public GameObject Hat;
    public GameObject self;
    public AudioSource Moan;

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

            Instantiate(Hat, new Vector3(transform.position.x, transform.position.y + 5, transform.position.z), transform.rotation);

            Moan.Play(0);

            Destroy(self);
        }
    }
}