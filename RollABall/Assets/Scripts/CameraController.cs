using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // calculating the difference  between the position of the camera and the player
        offset = transform.position - player.transform.position;
    }

    // LateUpdate waits until everything has been executed
    void LateUpdate()
    {
        // update position of camera
        transform.position = player.transform.position + offset;
    }
}
