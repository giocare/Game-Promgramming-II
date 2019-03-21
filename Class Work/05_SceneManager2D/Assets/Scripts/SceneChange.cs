using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //NOTE : this script is placed on the camera
    public int sceneToLoad;

    private void OnGUI()
    {
        //make button -> (x position, y position, width, height), "button content"
        //this function returns a bool then executes if true
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height - 50, 100, 40), "Next"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
       
    }


}
