using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigLvl2 : MonoBehaviour
{
    public string sceneName;
    private Animator objectAnimator;
    public GameObject objectWithAnimator;
    private Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        objectAnimator = objectWithAnimator.GetComponent<Animator>();
        myAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && GameControl.control.coincheck == true)
        {
            myAnimator.SetBool("lock_activated", true);
            StartCoroutine(MyMethod());
            //LoadNextScene();
            /*if (objectAnimator.GetBool("door_activated") == false)
            {
                Debug.Log("Door is open and ready to enter");
                LoadNextScene();
            }*/
        }

    }

    IEnumerator MyMethod()
    {
        Debug.Log("Before Waiting 5 seconds");
        objectAnimator.SetBool("door_activated", true);
        yield return new WaitForSeconds(5);
        objectAnimator.SetBool("door_activated", false);
        myAnimator.SetBool("lock_activated", false);
        //Debug.Log("After Waiting 2 Seconds");
    }
}
