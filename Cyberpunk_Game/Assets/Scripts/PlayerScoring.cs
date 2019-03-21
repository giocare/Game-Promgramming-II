using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScoring : MonoBehaviour
{
    public Text healthText;
    //public Text coinText;
    public string deathScene;

    private void Awake()
    {

        healthText.text = "Health: " + GameControl.control.health.ToString();
        //coinText.text = "Coins To : " + GameControl.control.coin.ToString();  
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
      /*  if (collision.gameObject.tag == "Coin")
        {
            GameControl.control.coin--;
            coinText.text = "Coins To: " + GameControl.control.coin.ToString();
            Destroy(collision.gameObject);
        } */
        if(collision.gameObject.tag == "Enemy")
        {
            GameControl.control.health -= 100;
            healthText.text = "Health: " + GameControl.control.health.ToString();
            healthText.color = Color.red;
        }

        if (GameControl.control.health == 0)
        {
            SceneManager.LoadScene(deathScene);
        }
    }

    public void Reset()
    {
        GameControl.control.coincheck = false;
        GameControl.control.health = 1200;
    }

}