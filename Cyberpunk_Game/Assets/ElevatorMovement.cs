using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    private Vector3 og_pos;
    //private Vector3 scalar;
    public float speed;
    private bool left; //I set a boolean named left so that when true the object moves left

    void Start()
    {
        left = true; //I set left to true so it would move left first
        og_pos = transform.position;
        //scalar = transform.localScale;

    }

    void Update()
    {
        if (transform.position.y >= og_pos.y + 3f)
            left = true; //So if my X position is more 6.9 or more, left is set to true
        if (left)       //If Left is true it shall move 1 space to the left
            transform.Translate(0f, -speed * Time.deltaTime, 0f);

        if (transform.position.y <= og_pos.y - 3f)
            left = false;
        if (!left)    //But if its false (declared false on the above line) move right by the same speed
            transform.Translate(0f, speed * Time.deltaTime, 0f);     

    }
}
