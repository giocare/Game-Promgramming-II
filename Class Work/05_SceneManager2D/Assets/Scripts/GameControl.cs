using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl control; //refer to our script as control

    public int score;

    private void Awake()
    {
        if(control == null) // if control doesnt exist
        {
            control = this;
            DontDestroyOnLoad(gameObject); //dont desroy when the new scene is loaded
        }else if(control != this)
        {
            Destroy(gameObject);
        }
    }
}
