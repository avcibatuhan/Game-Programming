using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public float currentScore;
    void Start()
    {
        currentScore = 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentScore += Time.deltaTime;
        // Hocam alttaki satırda score normal şekilde işliyor fakat konsolda null reference exception hatası veriyor
        scoreText.text = "Score: " + currentScore.ToString("0");

    }

}
