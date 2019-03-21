using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorNextLevel : MonoBehaviour
{
    public string sceneName;
    private Animator objectAnimator;
    public GameObject objectWithAnimator;
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        objectAnimator = objectWithAnimator.GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && (GameControl.control.coincheck == true))
        {
            StartCoroutine(MyMethod());
            //LoadNextScene();
            /*if (objectAnimator.GetBool("door_activated") == false)
            {
                Debug.Log("Door is open and ready to enter");
                LoadNextScene();
            }*/
        }
        
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator MyMethod()
    {
        Debug.Log("Before Waiting 1 seconds");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);
        //Debug.Log("After Waiting 2 Seconds");
        GameControl.control.coincheck = false;
    }

}
