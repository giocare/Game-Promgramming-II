using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoWayPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;

    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            effector.rotationalOffset = 0f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            effector.rotationalOffset = 180f;
        }

    }
}
