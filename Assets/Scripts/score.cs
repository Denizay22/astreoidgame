using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public int point = 0;
    public Text scoreText;
    public Text highScore;

    private void Start() {
        point = 0;
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void addScore(int pointToAdd){
        point +=pointToAdd;
        PlayerPrefs.SetInt("CurrentScore", point);
        scoreText.text = point.ToString();
        if(point > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", point);
            highScore.text = point.ToString();
        }
    }
}
