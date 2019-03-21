using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public Text coinCount;
    //int health = 1000;
    public int c_count = 20;

    private void Start() { 
        coinCount.text = c_count.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Coin")
        {
            c_count -= 1;
            coinCount.text = c_count.ToString();
            Destroy(other.gameObject);
            Debug.Log("testing" + coinCount.text.ToString());
        }

        if(c_count == 0)
        {
            GameControl.control.coincheck = true;
            coinCount.text = "NONE. Head Towards The Door";
        }

    }

}
