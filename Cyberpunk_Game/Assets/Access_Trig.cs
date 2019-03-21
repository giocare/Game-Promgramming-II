using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Access_Trig : MonoBehaviour
{
    private Animator myAnimator;
    public Text coinText;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
        //myAnimator.SetBool("door_activated", true);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(0.ToString());
        if (other.tag == "Player" && (GameControl.control.coincheck==true))
        {
            //Debug.Log("Lock Activated");
            myAnimator.SetBool("lock_activated", true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("Lock Activated");
            myAnimator.SetBool("lock_activated", false);
        }
    }
}
