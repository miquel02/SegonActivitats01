using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Activitat_10 : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int score = 0;

    // Function to add points to the score
    public void AddPoint()
    {
        score++;

        scoreText.text = "Score: " + score.ToString();
    }
}