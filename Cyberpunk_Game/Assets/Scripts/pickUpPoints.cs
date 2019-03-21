using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUpPoints : MonoBehaviour {

    public Text scoreText;
    public Slider slidey;
    int score = 0;

    private void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        //slidey.value = score;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            score++;
            scoreText.text = "Score: " + score.ToString();
            Debug.Log(score);
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }

        
    }

}
