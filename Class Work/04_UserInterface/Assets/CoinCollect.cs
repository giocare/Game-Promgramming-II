using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public Text scoreText;
    public Slider slidey;
    int score = 0;

    private void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        slidey.value = score;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Coin")
        {
            score++;
            slidey.value = score;

            if (score == 5)
            {
                scoreText.text = "WINNER";
            }
            else
            {
                scoreText.text = "Score: " + score.ToString();
                Debug.Log(score);

            }
            Destroy(other.gameObject);
        }
    }
}
