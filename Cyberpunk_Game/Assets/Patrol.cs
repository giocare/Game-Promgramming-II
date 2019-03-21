using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    private Vector3 og_pos;
    //private Vector3 scalar;
    public float speed;
    private bool faceR = false;
    private bool left; //I set a boolean named left so that when true the object moves left
    public float distance = 3f;

    void Start()
    {
        left = true; //I set left to true so it would move left first
        og_pos = transform.position;
        //scalar = transform.localScale;

    }

    void Update()
    {
        if (transform.position.x >= og_pos.x + distance)
        {
            left = false;
            Flip();
        }
        if (left)
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }



        if (transform.position.x <= og_pos.x - distance)
        {
            left = true;
            Flip();
        }
        if (!left)    //But if its false (declared false on the above line) move right by the same speed
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
    }
    void Flip()
    {
        faceR = !faceR;
        Vector3 scalar = transform.localScale;
        scalar.x *= -1;
        transform.localScale = scalar;
    }
}
