using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPointTo : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 worldPos;
    UnityEngine.Camera cam;
    public Transform Ball;

    float zPos;

    void Start()
    {
        cam = UnityEngine.Camera.main;
    }

    void Update()
    {
        zPos = Vector3.Distance(Ball.position, cam.transform.position);

        mousePos = Input.mousePosition;
        mousePos.z = cam.nearClipPlane + zPos;

        worldPos = cam.ScreenToWorldPoint(mousePos);

        transform.position = worldPos;
    }
}
