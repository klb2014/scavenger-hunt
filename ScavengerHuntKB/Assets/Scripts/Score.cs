using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [Header("Default Score")]
    public int score = 0;
    [Header("Text Object for Displaying Score")]
    public TMP_Text scoreText;

    public void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }


    public void AddScore(int points)
    {
        score = score + points;
        scoreText.text = "Score: " + score.ToString();
    }
}
