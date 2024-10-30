using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public GameObject Button;
    int Score = 0;
    public TMP_Text scoreText;
    int Combo;
    int pointSystem;

    void Start()
    {
        Button = GameObject.FindGameObjectWithTag("MainButton");
    }

    void Update()
    {
        Combo = Button.GetComponent<Randomiser>().combo;
        scoreText.text = string.Format("Score: " + Score.ToString());

        if(Combo > 2.9 && Combo < 4.1)
        {
            pointSystem = 150;
        }
        else if(Combo > 4.9 && Combo < 9.1)
        {
            pointSystem = 200;
        }
        else if(Combo > 9.9)
        {
            pointSystem = 300;
        }
        else
        {
            pointSystem = 100;
        }
    }

    public void ScoreAdd()
    {

        Score += pointSystem;
    }
}
