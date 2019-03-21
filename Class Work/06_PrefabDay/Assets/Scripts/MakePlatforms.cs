using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlatforms : MonoBehaviour
{
    public GameObject platform_prefab;
    float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            GameObject p;
            p = Instantiate(platform_prefab, new Vector2(Random.Range(-9.4f, 9f), -4.4f), Quaternion.identity);
            p.transform.localScale = new Vector2(Random.Range(3,8), 0.2f);
            timer = 0;

        }
    }
}
