using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{

    public int Score = 0;
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = string.Format("Score: " + Score.ToString());
    }

    public void ScoreAdd()
    {
        Score += 100;
    }
}
