using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    float moveForce;
    Rigidbody2D rb;
    public GameObject manager;
    float time;

    // Use this for initialization
    void Start()
    {
        moveForce = 5;
        rb = GetComponent<Rigidbody2D>();
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(3);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-3);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * moveForce);
        }
        resetPos();
    }

    void resetPos()
    {
        if (transform.position.x <= -11)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= 11)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (transform.position.y <= -7)
        {
            transform.position = new Vector3(transform.position.x, 6, transform.position.z);
        }
        if (transform.position.y >= 7)
        {
            transform.position = new Vector3(transform.position.x, -6, transform.position.z);
        }
    }

}
