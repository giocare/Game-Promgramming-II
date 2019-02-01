using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPress : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;


    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5;
        turnSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
         {
            // transform.Translate(new Vector3(0, -1, 0));
            transform.Translate(Vector3.forward);
         }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0)*turnSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0)*turnSpeed);
        }


        // transform.Translate(new Vector3(0, 0, moveSpeed)*Time.deltaTime);
    }

    /* void OnMouseDown()
     {
         //print to console
        Debug.Log("Clicked!");

         // move up one when clicked
         transform.Translate(new Vector3(0,1,0));
     }
     */
}
