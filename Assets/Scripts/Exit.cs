using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    bool LevelCleared;
    public EventManager eventManager;

    // Start is called before the first frame update
    void Start()
    {
        LevelCleared = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (eventManager.score >= eventManager.unlockScore)
            LevelCleared = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball" && LevelCleared)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
