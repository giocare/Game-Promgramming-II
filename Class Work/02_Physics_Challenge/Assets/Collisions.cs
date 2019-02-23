using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("EW IVE BEEN TOUCHED");
        if (other.gameObject.tag == "sphere")
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {

            GetComponent<Renderer>().material.color = Color.yellow;
            GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("EW IM STILLL BEING TOUCHED");
    }

    void OnCollisionExit(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
