using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCircles : MonoBehaviour
{
    public GameObject circle_prefab;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++){
            GameObject c;
            c = Instantiate(circle_prefab, new Vector2(Random.Range(-10,10), 4.3f), Quaternion.identity);
            float randomScale = Random.Range(1, 5);
            c.transform.localScale = new Vector2(randomScale, randomScale);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //Fire1 = left mouse click
        {
            mousePos = Input.mousePosition;
            mousePos.z = 10;

            var targetPos = Camera.main.ScreenToWorldPoint(mousePos);

            //create new prefabs
            Instantiate(circle_prefab, targetPos, Quaternion.identity); //object, location, rotation
        }
    }
}
