using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    //public DeathMenu theDeathScreen;

    public static GameControl control;
    public int health;
    public bool coincheck = false;
   // public int coin;

    private void Awake()
    {
    if (control == null) // if control doesnt exist
    {
        control = this;
        DontDestroyOnLoad(gameObject); //dont desroy when the new scene is loaded
    }
    else if (control != this)
    {
        Destroy(gameObject);
    }
}
}
