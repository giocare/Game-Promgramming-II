using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shot_prefab;
    public Transform shotLoc;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shot_prefab, shotLoc.position, shotLoc.rotation);
        }
    }
}
