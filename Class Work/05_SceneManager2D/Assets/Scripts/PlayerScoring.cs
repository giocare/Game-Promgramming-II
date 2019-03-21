using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoring : MonoBehaviour
{
    public Text scoreText;

    private void Awake()
    {
        scoreText.text = "Score: " + GameControl.control.score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ScoreUp")
        {
            GameControl.control.score++;
            scoreText.text = "Score: " + GameControl.control.score.ToString();
        }
        if(collision.gameObject.tag == "ScoreDown")
        {
            GameControl.control.score--;
            scoreText.text = "Score: " + GameControl.control.score.ToString();
        }
    }
}
