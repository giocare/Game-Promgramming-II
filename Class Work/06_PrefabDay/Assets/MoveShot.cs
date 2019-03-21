using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShot : MonoBehaviour
{
    public float timer = 0;
    public float shotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        shotSpeed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * shotSpeed * Time.deltaTime);

        timer += Time.deltaTime;
        if(timer > 1)
        {
            Destroy(this.gameObject);
        }
    }
}
