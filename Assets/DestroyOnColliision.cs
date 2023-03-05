using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOnColliision : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            score += 1;
          //  scoreText.text = "Score: " + score.ToString();
        }
    }
}
