using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HighScoreTextScript : MonoBehaviour

{
    public TMPro.TMP_Text highScoreText;
    void Start()
    {
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("highScore", 0).ToString();
    }

}
