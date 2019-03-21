using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    int speed = 10;

    private bool faceR = true;

    void Update () {

        float vert = Input.GetAxis ("Vertical")*speed;
        float horz = Input.GetAxis ("Horizontal")*speed;

        vert *= Time.deltaTime;
        horz *= Time.deltaTime;

        transform.Translate(horz, vert, 0);

        if (faceR == false && horz > 0)
        {
            Flip();
        }
        else if (faceR == true && horz < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        faceR = !faceR;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

}
